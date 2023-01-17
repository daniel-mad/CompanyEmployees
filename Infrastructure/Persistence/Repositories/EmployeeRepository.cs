using Application.Interfaces.Repository;
using Domain.Models;
using Infrastructure.Persistence.DataContext;
using Infrastructure.Persistence.Repositories.Extensions;
using Microsoft.EntityFrameworkCore;
using Shared.RequestFeatures;

namespace Infrastructure.Persistence.Repositories;
public class EmployeeRepository : RepositoryBase<Employee>, IEmployeeRepository
{
    public EmployeeRepository(CompanyDbContext context) : base(context)
    {
    }

    public void CreateEmployeeForCompany(Guid companyId, Employee employee)
    {
        employee.CompanyId = companyId;
        Create(employee);
    }

    public void DeleteEmployee(Employee employee) => Delete(employee);

    public async Task<Employee?> GetEmployeeAsync(Guid companyId, Guid id, bool trackChanges) =>
       await FindByCondition(e => e.CompanyId == companyId && e.Id == id, trackChanges)
        .SingleOrDefaultAsync();

    public async Task<PagedList<Employee>> GetEmployeesAsync(Guid companyId, EmployeeParameters employeeParameters, bool trackChanges)
    {
        var employees = await FindByCondition(e => e.CompanyId == companyId, trackChanges)
       .FilterEmployees(employeeParameters.MinAge, employeeParameters.MaxAge)
       .Search(employeeParameters.SearchTerm)
        .Sort(employeeParameters.OrderBy)
        .ToListAsync();
        var count = await FindByCondition(e => e.CompanyId == companyId, trackChanges).CountAsync();
        return PagedList<Employee>.ToPageList(employees, employeeParameters.PageNumber, employeeParameters.PageSize);

    }
}

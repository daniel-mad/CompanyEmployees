using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistence.Configuration;
public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
{
    public void Configure(EntityTypeBuilder<Employee> builder)
    {
        builder.HasData(
            new Employee
            {
                Id = Guid.NewGuid(),
                Name = "Daniel Madhala",
                Age = 35,
                Position = "Software Developer",
                CompanyId = new Guid("c3001bfb-4754-4336-8815-687d96bb1958")
            },
              new Employee
              {
                  Id = Guid.NewGuid(),
                  Name = "Gil Nevo",
                  Age = 30,
                  Position = "Software Developer",
                  CompanyId = new Guid("c3001bfb-4754-4336-8815-687d96bb1958")
              },
                new Employee
                {
                    Id = Guid.NewGuid(),
                    Name = "Boris Johnson",
                    Age = 85,
                    Position = "Administrator",
                    CompanyId = new Guid("e1fde970-910e-45b5-a835-8a7208eff896")
                }
            );
    }
}

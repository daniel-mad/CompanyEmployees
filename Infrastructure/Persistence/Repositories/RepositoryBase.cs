using Application.Interfaces.Repository;
using Infrastructure.Persistence.DataContext;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistence.Repositories;
public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class
{
    protected CompanyDbContext _context;

    public RepositoryBase(CompanyDbContext context)
    {
        _context = context;
    }
    public IQueryable<T> FindAll(bool trackChanges)
    {
        return !trackChanges ? _context.Set<T>().AsNoTracking() : _context.Set<T>();
    }

    public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression, bool trackChanges)
    {
        return !trackChanges ? _context.Set<T>().Where(expression).AsNoTracking() : _context.Set<T>().Where(expression);
    }

    public void Create(T entity)
    {
        _context.Set<T>().Add(entity);
    }
    public void Update(T entity)
    {
        _context.Set<T>().Update(entity);
    }

    public void Delete(T entity)
    {
        _context.Set<T>().Remove(entity);
    }
    
}

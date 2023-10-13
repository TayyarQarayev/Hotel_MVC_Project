using DataAccessLayer.Abstrct;
using DataAccessLayer.Concrete.EntityFrameworkCore.Context;
using Entity.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.EntityFrameworkCore;

public class EfGenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class, IBaseTable, new()
{
    //Context object
    private readonly HotelEcommerceContext _context;
    public EfGenericRepository(HotelEcommerceContext context)
    {
        _context = context;
    }

    //DbSet
    public DbSet<TEntity> Table => _context.Set<TEntity>();

    //Method()
    public async Task<bool> AddAsync(TEntity entity)
    {
        var state = await Table.AddAsync(entity);
        return EntityState.Added == state.State;
    }

    public async Task<bool> AddRangeAsync(ICollection<TEntity> entities)
    {
        await Table.AddRangeAsync(entities);
        return true;
    }

    public async Task<IEnumerable<TEntity>> GetAll()
    {
        return await Table.ToListAsync();
    }

    public IQueryable<TEntity> GetWhere(Expression<Func<TEntity, bool>> expression)
    {
        return Table.Where(expression);
    }

    public bool Remove(TEntity entity)
    {
        var state  = Table.Remove(entity);
        return EntityState.Deleted == state.State;
    }

    public bool RemoveRange(ICollection<TEntity> entities)
    {
        Table.RemoveRange(entities);
        return true;
    }

    public async Task SaveChanges()
    {
       await _context.SaveChangesAsync();
    }

    public bool Update(TEntity entity)
    {
        var state = Table.Update(entity);
        return EntityState.Modified == state.State;
    }
}

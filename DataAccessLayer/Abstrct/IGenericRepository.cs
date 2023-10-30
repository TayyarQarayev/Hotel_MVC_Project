using Entity.Abstract;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstrct;

public interface IGenericRepository<TEntity> where TEntity : class, IBaseTable, new()
{
    DbSet<TEntity> Table { get; }
    Task<bool> AddAsync(TEntity entity);
    Task<bool> AddRangeAsync(ICollection<TEntity> entities);
    bool Remove(TEntity entity);
    bool RemoveRange(ICollection<TEntity> entities);
    bool Update(TEntity entity);
    Task<IEnumerable<TEntity>> GetAll();

    Task<TEntity> GetById(int id);
    IQueryable<TEntity> GetWhere(Expression<Func<TEntity,bool>> expression);

    Task SaveChanges();
}

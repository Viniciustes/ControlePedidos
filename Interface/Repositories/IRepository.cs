using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Interface.Repositories
{
    public interface IRepository<TEntity> where TEntity : BaseEntity
    {
        Task<List<TEntity>> Get();

        Task<TEntity> GetById(int id);

        IQueryable<TEntity> Find(Expression<Func<TEntity, bool>> expression);

        Task<bool> Exist(Expression<Func<TEntity, bool>> expression);

        Task<int> Add(TEntity entity);

        Task<int> Remove(int id);

        Task<int> Update(TEntity entity);
    }
}
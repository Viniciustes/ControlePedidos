using Domain.Entities;
using Interface.Repositories;
using Microsoft.EntityFrameworkCore;
using Repository.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Repository.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : BaseEntity
    {
        private readonly DbSet<TEntity> _dbSet;
        private readonly ApplicationDbContext _context;

        public Repository(ApplicationDbContext context)
        {
            _context = context;
            _dbSet = _context.Set<TEntity>();
        }

        public async Task<List<TEntity>> Get()
        {
            return await _dbSet.AsNoTracking().ToListAsync();
        }

        public async Task<TEntity> GetById(int id)
        {
            return await _dbSet.FindAsync(id);
        }

        public IQueryable<TEntity> Find(Expression<Func<TEntity, bool>> expression)
        {
            return _dbSet.Where(expression).AsNoTracking();
        }

        public async Task<bool> Exist(Expression<Func<TEntity, bool>> expression)
        {
            return await _dbSet.AnyAsync(expression);
        }

        public async Task<int> Add(TEntity entity)
        {
            await _dbSet.AddAsync(entity);

            await _context.SaveChangesAsync();

            return await Task.FromResult(entity.Id);
        }

        public async Task<int> Update(TEntity entity)
        {
            _dbSet.Update(entity);

            await _context.SaveChangesAsync();

            return await Task.FromResult(entity.Id);
        }

        public async Task<int> Remove(int id)
        {
            var entity = await GetById(id);

            if (entity != null)
            {
                Remove(entity);

                await _context.SaveChangesAsync();

                return await Task.FromResult(id);
            }

            return await Task.FromResult(0);
        }

        private void Remove(TEntity entity)
        {
            _dbSet.Remove(entity);
        }
    }
}
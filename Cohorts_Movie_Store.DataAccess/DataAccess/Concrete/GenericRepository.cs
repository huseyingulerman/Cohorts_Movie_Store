﻿using Cohorts_Movie_Store.Core.Entities.Interfaces;
using Cohorts_Movie_Store.DataAccess.Context;
using Cohorts_Movie_Store.DataAccess.DataAccess.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Cohorts_Movie_Store.DataAccess.DataAccess.Concrete
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class, IEntity
    {
        private readonly MovieStoreDbContext _context;
        private readonly DbSet<T> _table;
        public GenericRepository(MovieStoreDbContext context)
        {
            _context = context;
            _table = _context.Set<T>();

        }
        public async Task<bool> Activate(int id)
        {
            T item = GetByID(id);
            item.IsActive = true;
            return Update(item);
        }

        public async Task<bool> Add(T entity)
        {
            try
            {
                await _table.AddAsync(entity);

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public T GetByID(int id) => _table.Find(id);

        public IQueryable<T> GetByID(int id, params Expression<Func<T, object>>[] includes)
        {
            var query = _table.Where(x => x.Id == id);
            if (includes != null)
            {
                query = includes.Aggregate(query, (current, include) => current.Include(include));
            }
            return query;
        }

        public async Task<List<T>> GetActive() => await _table.Where(x => x.IsActive == true).ToListAsync();

        public bool Remove(T entity)
        {
            entity.IsActive = false;
            return Update(entity);
        }

        public async Task<T> GetByDefault(params Expression<Func<T, bool>>[] exps)
        {
            IQueryable<T> query = _table.AsQueryable();

            foreach (var exp in exps)
            {
                query = query.Where(exp);
            }
            return query.FirstOrDefault();
        }
        public async Task<IQueryable<T>> GetAllByParametersAsync(Expression<Func<T, object>> include, params Expression<Func<T, bool>>[] exps)
        {

            IQueryable<T> query = _table.AsQueryable();
            query = query.Include(include);
            foreach (var exp in exps)
            {
                query = query.Where(exp);
            }

            return query;
        }

        public bool Remove(int id)
        {
            try
            {
                using (TransactionScope ts = new TransactionScope())
                {
                    T item = GetByID(id);
                    item.IsActive = false;
                    ts.Complete();
                    return Update(item);
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Update(T entity)
        {
            try
            {
                _table.Update(entity);

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}

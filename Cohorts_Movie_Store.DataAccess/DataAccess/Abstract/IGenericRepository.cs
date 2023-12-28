using Cohorts_Movie_Store.Core.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Cohorts_Movie_Store.DataAccess.DataAccess.Abstract
{
    public interface IGenericRepository<T> where T : class, IEntity
    {
        Task<bool> Activate(int id);
        Task<List<T>> GetActive();
        Task<bool> Add(T entity);
        T GetByID(int id);
        Task<T> GetByDefault(params Expression<Func<T, bool>>[] exps);
        Task<IQueryable<T>> GetAllByParametersAsync(Expression<Func<T, object>> include, params Expression<Func<T, bool>>[] exps);
        bool Remove(int id);
        bool Remove(T entity);
        bool Update(T entity);
    }
}

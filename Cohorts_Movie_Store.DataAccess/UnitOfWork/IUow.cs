using Cohorts_Movie_Store.Core.Entities.Interfaces;
using Cohorts_Movie_Store.DataAccess.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cohorts_Movie_Store.DataAccess.UnitOfWork
{
    public interface IUow
    {
        void Complete();
        void CompleteWithTransaction();
        IGenericRepository<T> GetRepository<T>() where T : class, IEntity;
    }
}

using Cohorts_Movie_Store.Business.Services.Generic;
using Cohorts_Movie_Store.Dtos.Purchased;
using Cohorts_Movie_Store.Entities.DbSets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cohorts_Movie_Store.Business.Services.Purchased
{
    public interface IPurchasedService : IGenericService<Cohorts_Movie_Store.Entities.DbSets.Purchased, PurchasedRequest, PurchasedResponse>
    {
    }
}

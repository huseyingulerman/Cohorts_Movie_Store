using Cohorts_Movie_Store.Business.Services.Generic;
using Cohorts_Movie_Store.Dtos.Customer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cohorts_Movie_Store.Business.Services.Customer
{
    public interface ICustomerService : IGenericService<Cohorts_Movie_Store.Entities.DbSets.Customer, CustomerRequest, CustomerResponse>
    {
    }
}

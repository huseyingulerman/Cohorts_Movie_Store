using AutoMapper;
using Cohorts_Movie_Store.Business.Services.Generic;
using Cohorts_Movie_Store.DataAccess.UnitOfWork;
using Cohorts_Movie_Store.Dtos.Customer;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cohorts_Movie_Store.Business.Services.Customer
{
    public class CustomerService : GenericService<Cohorts_Movie_Store.Entities.DbSets.Customer, CustomerRequest, CustomerResponse>, ICustomerService
    {
        public CustomerService(IUow uow, IMapper mapper, IValidator<CustomerRequest> validator) : base(uow, mapper, validator)
        {
        }
    }
}

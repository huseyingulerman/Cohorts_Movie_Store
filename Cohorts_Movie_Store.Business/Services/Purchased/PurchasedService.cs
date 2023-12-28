using AutoMapper;
using Cohorts_Movie_Store.Business.Services.Generic;
using Cohorts_Movie_Store.DataAccess.UnitOfWork;
using Cohorts_Movie_Store.Dtos.Purchased;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cohorts_Movie_Store.Business.Services.Purchased
{
    public class PurchasedService : GenericService<Cohorts_Movie_Store.Entities.DbSets.Purchased, PurchasedRequest, PurchasedResponse>, IPurchasedService
    {
        public PurchasedService(IUow uow, IMapper mapper, IValidator<PurchasedRequest> validator) : base(uow, mapper, validator)
        {
        }
    }
}

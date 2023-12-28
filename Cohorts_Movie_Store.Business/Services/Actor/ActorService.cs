using AutoMapper;
using Cohorts_Movie_Store.Business.Services.Generic;
using Cohorts_Movie_Store.DataAccess.UnitOfWork;
using Cohorts_Movie_Store.Dtos.Actor;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cohorts_Movie_Store.Business.Services.Actor
{
    public class ActorService : GenericService<Cohorts_Movie_Store.Entities.DbSets.Actor, ActorRequest, ActorResponse>, IActorService
    {
        public ActorService(IUow uow, IMapper mapper, IValidator<ActorRequest> validator) : base(uow, mapper, validator)
        {
        }
    }
}

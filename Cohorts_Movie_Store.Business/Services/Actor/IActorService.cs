using Cohorts_Movie_Store.Business.Services.Generic;
using Cohorts_Movie_Store.Dtos.Actor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cohorts_Movie_Store.Business.Services.Actor
{
    public interface IActorService : IGenericService<Cohorts_Movie_Store.Entities.DbSets.Actor, ActorRequest, ActorResponse>
    {
    }
}

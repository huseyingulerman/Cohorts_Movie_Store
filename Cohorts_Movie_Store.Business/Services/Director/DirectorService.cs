using AutoMapper;
using Cohorts_Movie_Store.Business.Services.Generic;
using Cohorts_Movie_Store.DataAccess.UnitOfWork;
using Cohorts_Movie_Store.Dtos.Director;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cohorts_Movie_Store.Business.Services.Director
{
    public class DirectorService : GenericService<Cohorts_Movie_Store.Entities.DbSets.Director, DirectorRequest, DirectorResponse>, IDirectorService
    {
        public DirectorService(IUow uow, IMapper mapper, IValidator<DirectorRequest> validator) : base(uow, mapper, validator)
        {
        }
    }
}

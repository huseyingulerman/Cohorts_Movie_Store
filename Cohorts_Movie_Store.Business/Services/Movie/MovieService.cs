using AutoMapper;
using Cohorts_Movie_Store.Business.Services.Generic;
using Cohorts_Movie_Store.DataAccess.UnitOfWork;
using Cohorts_Movie_Store.Dtos.Movie;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cohorts_Movie_Store.Business.Services.Movie
{
    public class MovieService : GenericService<Cohorts_Movie_Store.Entities.DbSets.Movie, MovieRequest, MovieResponse>, IMovieService
    {
        public MovieService(IUow uow, IMapper mapper, IValidator<MovieRequest> validator) : base(uow, mapper, validator)
        {
        }
    }
}

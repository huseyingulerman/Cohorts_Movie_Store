using Cohorts_Movie_Store.Business.Services.Generic;
using Cohorts_Movie_Store.Dtos.Movie;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cohorts_Movie_Store.Business.Services.Movie
{
    public interface IMovieService : IGenericService<Cohorts_Movie_Store.Entities.DbSets.Movie, MovieRequest, MovieResponse>
    {
    }
}

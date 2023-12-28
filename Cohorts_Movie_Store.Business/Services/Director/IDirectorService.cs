using Cohorts_Movie_Store.Business.Services.Generic;
using Cohorts_Movie_Store.Dtos.Director;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cohorts_Movie_Store.Business.Services.Director
{
    public interface IDirectorService : IGenericService<Cohorts_Movie_Store.Entities.DbSets.Director, DirectorRequest, DirectorResponse>
    {
    }
}

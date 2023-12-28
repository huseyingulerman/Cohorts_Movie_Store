using Cohorts_Movie_Store.Core.Entities.BaseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cohorts_Movie_Store.Entities.DbSets
{
    public class Director : BaseUser
    {
        public Director()
        {
            Movies = new HashSet<Movie>();
        }
        public ICollection<Movie> Movies { get; set; }
    }
}

using Cohorts_Movie_Store.Core.Entities.BaseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cohorts_Movie_Store.Entities.DbSets
{
    public class Actor : BaseUser
    {
        public Actor()
        {
            Movies=new HashSet<MovieActor>();
        }
        public ICollection<MovieActor> Movies { get; set; }
    }
}

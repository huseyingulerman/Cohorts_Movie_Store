using Cohorts_Movie_Store.Core.Entities.BaseEntities;
using Cohorts_Movie_Store.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cohorts_Movie_Store.Entities.DbSets
{
    public class Movie : BaseEntity
    {
        public Movie()
        {
            Actors = new HashSet<MovieActor>();
            Purchaseds = new HashSet<Purchased>();
        }
        public string Name { get; set; }
        public int Year { get; set; }
        public Genre Genre { get; set; }
        public decimal Price { get; set; }
        public ICollection<MovieActor> Actors { get; set; }
        public int DirectorId { get; set; }
        public Director Director { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public ICollection<Purchased> Purchaseds { get; set; }
    }
}

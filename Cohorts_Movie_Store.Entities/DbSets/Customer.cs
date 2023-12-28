using Cohorts_Movie_Store.Core.Entities.BaseEntities;
using Cohorts_Movie_Store.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cohorts_Movie_Store.Entities.DbSets
{
    public class Customer : BaseUser
    {
        public Customer()
        {
            Movies = new HashSet<Movie>();
            FavoriteGenres = new List<Genre>();
            Purchaseds = new HashSet<Purchased>();
        }
        public string Email { get; set; }
        public string Password { get; set; }
        public ICollection<Movie> Movies { get; set; }
        public List<Genre> FavoriteGenres { get; set; }
        public ICollection<Purchased> Purchaseds { get; set; }
    }
}

using Cohorts_Movie_Store.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cohorts_Movie_Store.Dtos.Movie
{
    public class MovieRequest
    {
        public string Name { get; set; }
        public int Year { get; set; }
        public Genre Genre { get; set; }
        public decimal Price { get; set; }
        public int DirectorId { get; set; }
        public int CustomerId { get; set; }
    }
}

using Cohorts_Movie_Store.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cohorts_Movie_Store.Dtos.Customer
{
    public class CustomerResponse
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public List<Genre> FavoriteGenres { get; set; }
    }
}

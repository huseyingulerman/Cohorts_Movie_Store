using Cohorts_Movie_Store.DataAccess.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cohorts_Movie_Store.UnitTest.Application.TestSetup.Data
{
    public static class Director
    {
        public static void AddDirector(this MovieStoreDbContext context)
        {
            context.Directors.AddRange(
                new Cohorts_Movie_Store.Entities.DbSets.Director { Firstname = "Stanley", Lastname = "Kubrick", CreatedBy = "admin" },
                new Cohorts_Movie_Store.Entities.DbSets.Director { Firstname = "Charlie", Lastname = "Chaplin", CreatedBy = "admin", },
                new Cohorts_Movie_Store.Entities.DbSets.Director { Firstname = "Hayao", Lastname = "Miyazaki", CreatedBy = "admin" });
        }
    }
}

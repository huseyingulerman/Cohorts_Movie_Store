using Cohorts_Movie_Store.DataAccess.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cohorts_Movie_Store.UnitTest.Application.TestSetup.Data
{
    public static class Actor
    {
        public static void AddActors(this MovieStoreDbContext context)
        {
            context.Actors.AddRange(
                new Entities.DbSets.Actor { Firstname = "Tom", Lastname = "Cruise", CreatedBy = "admin" },
                new Entities.DbSets.Actor { Firstname = "Natalie", Lastname = "Portman", CreatedBy = "admin" },
                new Entities.DbSets.Actor { Firstname = "Christian", Lastname = "Bale", CreatedBy = "admin" });
        }
    }
}

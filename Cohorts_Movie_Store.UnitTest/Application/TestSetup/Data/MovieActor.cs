﻿using Cohorts_Movie_Store.DataAccess.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cohorts_Movie_Store.UnitTest.Application.TestSetup.Data
{
    public static class MovieActor
    {
        public static void AddMovieActor(this MovieStoreDbContext context)
        {
            context.MovieActors.AddRange(
               new Entities.DbSets.MovieActor { ActorId=1, MovieId=2, CreatedBy="admin" },
               new Entities.DbSets.MovieActor { ActorId=2, MovieId=1, CreatedBy="admin" },
               new Entities.DbSets.MovieActor { ActorId=3, MovieId=3, CreatedBy="admin" });
        }
    }
}

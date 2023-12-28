﻿using Cohorts_Movie_Store.Entities.DbSets;
using Cohorts_Movie_Store.EntitiesConfiguration;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cohorts_Movie_Store.DataAccess.Context
{
    public class MovieStoreDbContext : DbContext, IMovieStoreDbContext
    {
        public MovieStoreDbContext(DbContextOptions<MovieStoreDbContext> options) : base(options)
        {

        }

        public DbSet<Actor> Actors { get; set; }
        public DbSet<MovieActor> MovieActors { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Director> Directors { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Purchased> Purchaseds { get; set; }
        public override int SaveChanges()
        {
            return base.SaveChanges();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ActorConfiguration());
            modelBuilder.ApplyConfiguration(new CustomerConfiguration());
            modelBuilder.ApplyConfiguration(new DirectorConfiguration());
            modelBuilder.ApplyConfiguration(new MovieConfiguration());
            modelBuilder.ApplyConfiguration(new PurchasedConfiguration());
            base.OnModelCreating(modelBuilder);
        }
    }
}

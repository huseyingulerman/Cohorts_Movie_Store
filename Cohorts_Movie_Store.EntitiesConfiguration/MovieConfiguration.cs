﻿using Cohorts_Movie_Store.Core.Entities.EntityTypeConfigurations;
using Cohorts_Movie_Store.Entities.DbSets;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cohorts_Movie_Store.EntitiesConfiguration
{
    public class MovieConfiguration : BaseEntityConfiguration<Movie>
    {
        public override void Configure(EntityTypeBuilder<Movie> builder)
        {
            base.Configure(builder);
            builder.Property(x => x.Name).IsRequired().HasMaxLength(128);
            builder.Property(x => x.Year).IsRequired();
            builder.Property(x => x.Genre).IsRequired();
            builder.Property(x => x.Price).IsRequired();
            builder.HasMany(x => x.Actors).WithOne(x => x.Movie).HasForeignKey(x => x.MovieId);
            builder.HasMany(x => x.Purchaseds).WithOne(x => x.Movie).HasForeignKey(x => x.MovieId);

        }
    }
}

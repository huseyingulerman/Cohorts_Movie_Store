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
    public class ActorConfiguration : BaseUserConfiguration<Actor>
    {
        public override void Configure(EntityTypeBuilder<Actor> builder)
        {
            base.Configure(builder);
            builder.HasMany(x => x.Movies).WithOne(x => x.Actor).HasForeignKey(x => x.ActorId);
        }
    }
}

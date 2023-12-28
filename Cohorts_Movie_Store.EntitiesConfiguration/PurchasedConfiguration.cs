using Cohorts_Movie_Store.Core.Entities.EntityTypeConfigurations;
using Cohorts_Movie_Store.Entities.DbSets;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cohorts_Movie_Store.EntitiesConfiguration
{
    public class PurchasedConfiguration : BaseEntityConfiguration<Purchased>
    {
        public override void Configure(EntityTypeBuilder<Purchased> builder)
        {
            base.Configure(builder);
            builder.Property(x => x.Price).IsRequired();
        }
    }
}

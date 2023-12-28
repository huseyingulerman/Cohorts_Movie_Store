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
    public class CustomerConfiguration : BaseUserConfiguration<Customer>
    {
        public override void Configure(EntityTypeBuilder<Customer> builder)
        {
            base.Configure(builder);
            builder.Property(x => x.Email).HasMaxLength(128).IsRequired();
            builder.Property(x => x.Password).HasMaxLength(50).IsRequired();
            builder.HasMany(x => x.Movies).WithOne(x => x.Customer).HasForeignKey(x => x.CustomerId);
            builder.HasMany(x => x.Purchaseds).WithOne(x => x.Customer).HasForeignKey(x => x.CustomerId);

        }
    }
}

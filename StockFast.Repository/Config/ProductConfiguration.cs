using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StockFast.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace StockFast.Repository.Config
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(o => o.Id);
            builder
                .HasMany(o => o.Providers);
            builder.HasMany(o => o.ProductGroups);
            builder.HasMany(o => o.ProductBrands);
            builder.HasMany(o => o.GetProductEntries);
            builder.HasMany(o => o.ExitProducts);


                

        }
    }
}

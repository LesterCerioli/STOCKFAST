using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StockFast.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace StockFast.Repository.Config
{
    public class ProductGroupConfiguration : IEntityTypeConfiguration<ProductGroup>
    {
        public void Configure(EntityTypeBuilder<ProductGroup> builder)
        {
            builder.HasKey(q => q.Id);
        }
    }
}

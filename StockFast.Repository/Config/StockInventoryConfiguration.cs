using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StockFast.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace StockFast.Repository.Config
{
    public class StockInventoryConfiguration : IEntityTypeConfiguration<StockInventory>
    {
        public void Configure(EntityTypeBuilder<StockInventory> builder)
        {
            builder.HasKey(u => u.Id);
            builder
                .Property(u => u.Data)
                .IsRequired()
                .HasColumnType("datetime");
            builder.HasMany(o => o.Products);
            builder.HasMany(o => o.ProductBrands);
            builder
                .Property(u => u.QuantidadeEstoque)
                .HasColumnType("int")
                .IsRequired();
            builder.HasMany(u => u.ProductBrands);
            builder.HasMany(u => u.Products);
            builder.HasMany(u => u.Meansurement_Units);
            builder.HasMany(u => u.ExitProducts);
            builder.HasMany(u => u.ProductEntries);
            builder.HasMany(u => u.ItemVendas);




        }
    }
}

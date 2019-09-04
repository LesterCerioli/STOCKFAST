﻿using Microsoft.EntityFrameworkCore;
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



        }
    }
}

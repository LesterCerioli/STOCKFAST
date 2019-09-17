using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StockFast.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace StockFast.Repository.Config
{
    public class CityConfiguration : IEntityTypeConfiguration<City>
    {
        public void Configure(EntityTypeBuilder<City> builder)
        {
            builder.HasKey(e => e.Id);
            builder
                .Property(e => e.Nome)
                .HasColumnType("nvarchar")
                .IsRequired()
                .HasMaxLength(50);
            builder
                .Property(e => e.Ativo)
                .HasColumnType("bool")
                .IsRequired();
            builder
                .HasMany(e => e.States);
                
        }
    }
}

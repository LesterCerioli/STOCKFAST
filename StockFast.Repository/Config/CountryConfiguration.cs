using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StockFast.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace StockFast.Repository.Config
{
    public class CountryConfiguration : IEntityTypeConfiguration<Country>
    {
        public void Configure(EntityTypeBuilder<Country> builder)
        {
            builder.HasKey(c => c.Id);

            builder
                .Property(c => c.Nome)
                .IsRequired()
                .HasMaxLength(95)
                .HasColumnType("nvarchar");
            builder
                .Property(c => c.Codigo)
                .IsRequired();
            builder
                .Property(c => c.Ativo)
                .IsRequired()
                .HasColumnType("bool");
            builder
                .HasMany(c => c.States);

        }

    }
}

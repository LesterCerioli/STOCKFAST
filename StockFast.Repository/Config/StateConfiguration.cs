using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StockFast.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace StockFast.Repository.Config
{
    public class StateConfiguration : IEntityTypeConfiguration<State>
    {
        public void Configure(EntityTypeBuilder<State> builder)
        {
            builder.HasKey(t => t.Id);
            builder
                .Property(t => t.Nome)
                .IsRequired()
                .HasMaxLength(95)
                .HasColumnType("nvarchar");
            builder
                .Property(t => t.UF)
                .IsRequired()
                .HasColumnType("char")
                .HasMaxLength(2);
            builder
                .Property(t => t.Ativo)
                .IsRequired()
                .HasColumnType("bool");
            builder.HasMany(t => t.Cities); 
        }
    }
}

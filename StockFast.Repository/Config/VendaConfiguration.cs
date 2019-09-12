using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StockFast.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace StockFast.Repository.Config
{
    public class VendaConfiguration : IEntityTypeConfiguration<Venda>
    {
        public void Configure(EntityTypeBuilder<Venda> builder)
        {
            builder.HasKey(v => v.Id);

            builder
                .Property(v => v.DataVenda)
                .IsRequired();
            builder
                .Property(v => v.DataPrevisaoEntrega)
                .IsRequired();
            builder
                .Property(v => v.CEP)
                .IsRequired()
                .HasMaxLength(10);
            builder
                .Property(v => v.Estado)
                .IsRequired()
                .HasMaxLength(100);
            builder
                .Property(v => v.Cidade)
                .IsRequired()
                .HasMaxLength(100);
            builder
                .Property(v => v.Pais)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(100);
            builder
                .Property(v => v.UF)
                .IsRequired()
                .HasMaxLength(2)
                .HasColumnType("varchar");
                
            builder.HasOne(v => v.FormaPagamento);
            builder.HasMany(v => v.ItensVenda);
            
        }
    }
}

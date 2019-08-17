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
            builder.HasKey(b => b.Id);
            builder
                .Property(b => b.DataVenda)
                .IsRequired();
            builder.HasKey(b => b.UsuarioId);
            builder
                .Property(b => b.DataPrevisaoEntrega)
                .IsRequired();

            builder
                .Property(b => b.CEP)
                .IsRequired()
                .HasMaxLength(15);

            builder
                .Property(b => b.Estado)
                .IsRequired()
                .HasMaxLength(2);

            builder
                .Property(b => b.Cidade)
                .IsRequired()
                .HasMaxLength(45);

            builder
                .Property(b => b.Pais)
                .IsRequired()
                .HasMaxLength(50);

            builder
                .Property(b => b.EnderecoCompleto)
                .IsRequired()
                .HasMaxLength(100);

            builder
                .Property(b => b.NumeroEndereco)
                .IsRequired();

            
            
                




        }
    }
}

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StockFast.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace StockFast.Repository.Config
{
    public class ProviderConfiguration : IEntityTypeConfiguration<Provider>
    {
        public void Configure(EntityTypeBuilder<Provider> builder)
        {
            builder.HasKey(s => s.Id);
            builder
                .Property(s => s.Nome)
                .IsRequired()
                .HasColumnType("nvarchar")
                .HasMaxLength(95);
            builder
                .Property(s => s.RazaoSocial)
                .IsRequired()
                .HasMaxLength(95)
                .HasColumnType("nvarchar");
            builder
                .Property(s => s.NumeroDocumento)
                .IsRequired()
                .HasColumnType("bigint");
            builder
                .Property(s => s.Tipo)
                .HasColumnType("int")
                .IsRequired();
            builder
                .Property(s => s.Telefone)
                .IsRequired()
                .HasColumnType("bigint");
            builder
                .Property(s => s.Contato)
                .IsRequired()
                .HasColumnType("nvarchar")
                .HasMaxLength(95);
            builder
                .Property(s => s.Logradouro)
                .IsRequired()
                .HasColumnType("nvarchar")
                .HasMaxLength(95);
            builder
                .Property(s => s.Numero)
                .IsRequired()
                .HasColumnType("bigint");
            builder
                .Property(s => s.Complemento)
                .IsRequired()
                .HasColumnType("nvarchar")
                .HasMaxLength(150);
            builder
                .Property(s => s.CEP)
                .HasColumnType("bigint")
                .IsRequired();
            builder.HasKey(c => c.CountryId);
            builder.HasKey(c => c.StateId);
            builder.HasKey(c => c.CityId);
            builder
                .Property(s => s.Ativo)
                .IsRequired()
                .HasColumnType("bool");
            


        }
    }
}

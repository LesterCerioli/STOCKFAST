using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StockFast.Domain.ObjetodeValor;
using System;
using System.Collections.Generic;
using System.Text;

namespace StockFast.Repository.Config
{
    public class FormaPagamentoConfiguration : IEntityTypeConfiguration<FormaPagamento>
    {
        public void Configure(EntityTypeBuilder<FormaPagamento> builder)
        {
            builder.HasKey(w => w.Id);
            builder
                .Property(w => w.Nome)
                .IsRequired()
                .HasMaxLength(50);
            builder
                .Property(w => w.Descricao)
                .IsRequired()
                .HasMaxLength(100);
        }
    }
}

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
                .Property(v => v.DataPrevisaoEntrega)
                .IsRequired()
                .HasColumnType("datete");
            builder.HasOne(v => v.User);
                
            builder.HasOne(w => w.FormaPagamento);
        }
    }
}

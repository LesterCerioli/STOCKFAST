using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StockFast.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace StockFast.Repository.Config
{
    public class ItemVendaConfiguration : IEntityTypeConfiguration<ItemVenda>
    {
        public void Configure(EntityTypeBuilder<ItemVenda> builder)
        {
            builder.HasKey(k => k.Id);
            builder
                .Property(k => k.ProdutoId)
                .IsRequired();
            builder
                .Property(k => k.Quantidade)
                .IsRequired();
            builder
                .HasMany(k => k.Vendas);
                
        }
    }
}

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StockFast.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace StockFast.Repository.Config
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(a => a.Id);
            builder
                .Property(a => a.Login)
                .IsRequired()
                .HasMaxLength(20);
            builder
                .Property(a => a.Senha)
                .IsRequired()
                .HasMaxLength(20);
            builder
                .Property(a => a.Nome)
                .IsRequired()
                .HasMaxLength(100);
            builder
                .Property(a => a.Email)
                .IsRequired()
                .HasMaxLength(95);
            builder
                .HasMany(a => a.Vendas)
                .WithOne(v => v.User);
            

            




        }
    }
}

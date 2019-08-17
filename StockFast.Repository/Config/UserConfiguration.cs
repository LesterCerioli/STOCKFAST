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
            builder.HasKey(u => u.Id);
            builder
                .Property(u => u.Login)
                .IsRequired()
                .HasMaxLength(10);
            builder
                .Property(u => u.Senha)
                .IsRequired()
                .HasMaxLength(25);
            builder
                .Property(u => u.Nome)
                .IsRequired()
                .HasMaxLength(100);
            builder
                .Property(u => u.Email)
                .IsRequired()
                .HasMaxLength(100);
        }
    }
}

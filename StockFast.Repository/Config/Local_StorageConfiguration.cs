using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StockFast.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace StockFast.Repository.Config
{
    public class Local_StorageConfiguration : IEntityTypeConfiguration<Local_Storage>
    {
        public void Configure(EntityTypeBuilder<Local_Storage> builder)
        {
            builder.HasKey(l => l.Id);
            builder.HasMany(l => l.Products);
            builder.HasMany(l => l.Countries);
            builder.HasMany(l => l.Cities);
            builder.HasMany(l => l.States);
        }
    }
}

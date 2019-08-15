using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StockFast.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace StockFast.Repository.Config
{
    public class StockInventoryConfiguration : IEntityTypeConfiguration<StockInventory>
    {
        public void Configure(EntityTypeBuilder<StockInventory> builder)
        {
            throw new NotImplementedException();
        }
    }
}

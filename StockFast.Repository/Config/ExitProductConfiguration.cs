using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StockFast.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace StockFast.Repository.Config
{
    public class ExitProductConfiguration : IEntityTypeConfiguration<ExitProduct>
    {
        public void Configure(EntityTypeBuilder<ExitProduct> builder)
        {
            throw new NotImplementedException();
        }
    }
}

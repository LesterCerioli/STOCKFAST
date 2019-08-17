    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using StockFast.Domain.Entities;
    using System;
    using System.Collections.Generic;
    using System.Text;

    namespace StockFast.Repository.Config
    {
        public class CityConfiguration : IEntityTypeConfiguration<City>
        {
            public void Configure(EntityTypeBuilder<City> builder)
            {
                throw new NotImplementedException();
            }
        }
    }

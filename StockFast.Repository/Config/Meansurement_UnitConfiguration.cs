﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StockFast.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace StockFast.Repository.Config
{
    public class Meansurement_UnitConfiguration : IEntityTypeConfiguration<Meansurement_Unit>
    {
        public void Configure(EntityTypeBuilder<Meansurement_Unit> builder)
        {
            throw new NotImplementedException();
        }
    }
}
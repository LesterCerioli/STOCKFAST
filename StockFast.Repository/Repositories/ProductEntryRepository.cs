﻿using StockFast.Domain.Contracts;
using StockFast.Domain.Entities;
using StockFast.Repository.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace StockFast.Repository.Repositories
{
    public class ProductEntryRepository : BaseRepository<ProductEntry>, IProductEntryRepository
    {
        public ProductEntryRepository(StockFastContext stockFastContext) : base(stockFastContext)
        {

        }
    }
}

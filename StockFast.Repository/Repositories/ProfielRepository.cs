﻿using StockFast.Domain.Contracts;
using StockFast.Domain.Entities;
using StockFast.Repository.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace StockFast.Repository.Repositories
{
    public class ProfielRepository : BaseRepository<Profile>, IProfileRepository
    {
        public ProfielRepository(StockFastContext stockFastContext) : base(stockFastContext)
        {

        }
    }
}

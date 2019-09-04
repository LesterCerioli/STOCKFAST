using StockFast.Domain.Contracts;
using StockFast.Domain.Entities;
using StockFast.Repository.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace StockFast.Repository.Repositories
{
    public class Meansurement_UnitRepository : BaseRepository<Meansurement_Unit>, IMeansurement_UnitRepository
    {
        public Meansurement_UnitRepository(StockFastContext stockFastContext) : base(stockFastContext)
        {

        }
    }
}

using StockFast.Domain.Contracts;
using StockFast.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace StockFast.Repository.Repositories
{
    public class StockInventoryRepository : BaseRepository<StockInventory>, IStockInventoryRepository
    {
        public StockInventoryRepository()
        {

        }
    }
}

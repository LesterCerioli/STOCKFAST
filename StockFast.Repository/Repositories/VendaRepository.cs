using StockFast.Domain.Contracts;
using StockFast.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace StockFast.Repository.Repositories
{
    public class VendaRepository : BaseRepository<Venda>, IVendaRepository
    {
        public VendaRepository()
        {

        }
    }
}

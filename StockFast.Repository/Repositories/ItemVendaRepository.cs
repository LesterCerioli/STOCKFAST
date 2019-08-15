using StockFast.Domain.Contracts;
using StockFast.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace StockFast.Repository.Repositories
{
    public class ItemVendaRepository : BaseRepository<ItemVenda>, IItemVendaRepository
    {
        public ItemVendaRepository()
        {

        }

        public void Adicionar(IItemVendaRepository entity)
        {
            throw new NotImplementedException();
        }

        public void Atualizar(IItemVendaRepository entity)
        {
            throw new NotImplementedException();
        }

        public void Remover(IItemVendaRepository entity)
        {
            throw new NotImplementedException();
        }

        IItemVendaRepository IBaseRepository<IItemVendaRepository>.ObterPorId(int id)
        {
            throw new NotImplementedException();
        }

        IEnumerable<IItemVendaRepository> IBaseRepository<IItemVendaRepository>.ObterTodos()
        {
            throw new NotImplementedException();
        }
    }
}

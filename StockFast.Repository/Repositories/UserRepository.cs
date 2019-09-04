using StockFast.Domain.Contracts;
using StockFast.Domain.Entities;
using StockFast.Repository.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace StockFast.Repository.Repositories
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        public UserRepository(StockFastContext stockFastContext) : base(stockFastContext)
        {

        }

        internal void Adicionar(UserRepository user)
        {
            throw new NotImplementedException();
        }
    }
}

using StockFast.Domain.Contracts;
using StockFast.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace StockFast.Repository.Repositories
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        public UserRepository()
        {

        }

        internal void Adicionar(UserRepository user)
        {
            throw new NotImplementedException();
        }
    }
}

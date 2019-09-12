using System;
using System.Collections.Generic;
using System.Text;

namespace StockFast.Domain.Entities
{
    public class ItemVenda : Entity
    {
        public int Id { get; set; }
        public int ProdutoId { get; set; }
        public int Quantidade { get; set; }
        public ICollection<Venda> Vendas { get; set; }

        public override void Validate()
        {
            throw new NotImplementedException();
        }
    }
}

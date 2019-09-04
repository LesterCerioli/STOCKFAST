using System;
using System.Collections.Generic;
using System.Text;

namespace StockFast.Domain.Entities
{
    public class ProductGroup : Entity
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public bool Ativo { get; set; }
        public virtual ICollection<StockInventory> StockInventories { get; set; }

        public override void Validate()
        {
            LimparMensagemValidacao();
            if (string.IsNullOrEmpty(Nome))
                AdicionarCritica("O Nome do Grupo de Produtos deve ser preenchido obrigatoriamente");
        }
        internal static bool Any()
        {
            throw new NotImplementedException();
        }
    }
}

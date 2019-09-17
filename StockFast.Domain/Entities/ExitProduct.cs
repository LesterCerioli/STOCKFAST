using System;
using System.Collections.Generic;
using System.Text;

namespace StockFast.Domain.Entities
{
    public class ExitProduct : Entity
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime Data { get; set; }
        public int ProductId { get; set; }
        public int Quantidade { get; set; }
        public virtual ICollection<Product> Products { get; set; }
        public virtual ICollection<ProductBrand> GetProductBrands { get; set; }
        public virtual ICollection<ProductGroup> ProductGroups { get; set; }


        public override void Validate()
        {
            LimparMensagemValidacao();
            if (string.IsNullOrEmpty(Nome))
                AdicionarCritica("O Nome deve ser preenchido obrigatoriamente");
            


        }
    }
}

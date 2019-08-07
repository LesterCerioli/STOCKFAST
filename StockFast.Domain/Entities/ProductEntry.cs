using System;
using System.Collections.Generic;
using System.Text;

namespace StockFast.Domain.Entities
{
    public class ProductEntry : Entity
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime Data { get; set; }
        public int  ProductId { get; set; }
        public int Qauntidade { get; set; }

        public override void Validate()
        {
            LimparMensagemValidacao();
            if (string.IsNullOrEmpty(Nome))
                AdicionarCritica("O 0Nome deve ser preenchido obrigatoriamente");
        }
    }
}

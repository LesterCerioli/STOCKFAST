using System;
using System.Collections.Generic;
using System.Text;

namespace StockFast.Domain.Entities
{
    public class City : Entity
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public bool Ativo { get; set; }
        public int StateId { get; set; }

        public override void Validate()
        {
            LimparMensagemValidacao();
            if (!City.Any())
                AdicionarCritica("A Cidade deve ser preenchida obrigatoriamente");
        }
        internal static bool Any()
        {
            throw new NotImplementedException();
        }
    }
}

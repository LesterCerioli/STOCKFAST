using System;
using System.Collections.Generic;
using System.Text;

namespace StockFast.Domain.Entities
{
    public class Country : Entity
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Codigo { get; set; }
        public bool Ativo { get; set; }

        public override void Validate()
        {
            LimparMensagemValidacao();
            if (!Country.Any())
                AdicionarCritica("O País deve ser preenchido obrigatoriamente");
        }
        internal static bool Any()
        {
            throw new NotImplementedException();
        }
    }
}

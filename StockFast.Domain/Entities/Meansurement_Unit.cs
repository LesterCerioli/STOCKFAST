using System;
using System.Collections.Generic;
using System.Text;

namespace StockFast.Domain.Entities
{
    public class Meansurement_Unit : Entity
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sigla { get; set; }
        public bool Ativo { get; set; }

        public override void Validate()
        {
            LimparMensagemValidacao();

            if (string.IsNullOrEmpty(Nome))
                AdicionarCritica("O Nome deve ser preenchido obrigatoriamente");

            if (string.IsNullOrEmpty(Sigla))
                AdicionarCritica("A Sigla deve ser preenchida obrigatoriamente");

            


        }
    }
}

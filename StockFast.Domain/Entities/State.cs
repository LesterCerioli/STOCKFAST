using System;
using System.Collections.Generic;
using System.Text;

namespace StockFast.Domain.Entities
{
    public class State : Entity
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string UF { get; set; }
        public bool Ativo { get; set; }
        public int CountryId { get; set; }
        public virtual ICollection<Country> Countries { get; set; }
        public virtual ICollection<City> Cities { get; set; }

        public override void Validate()
        {
            LimparMensagemValidacao();
            if (!State.Any())
                AdicionarCritica("O Estado deve ser preenchido obrigatoriamente");
        }
        internal static bool Any()
        {
            throw new NotImplementedException();
        }
    }
}

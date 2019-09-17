using System;
using System.Collections.Generic;
using System.Text;

namespace StockFast.Domain.Entities
{
    public class Local_Storage : Entity
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public bool Ativo { get; set; }
        public virtual ICollection<Product> Products { get; set; }
        public virtual ICollection<Country> Countries { get; set; }
        public virtual ICollection<State> States { get; set; }
        public virtual ICollection<City> Cities { get; set; }


        public override void Validate()
        {
            LimparMensagemValidacao();
            if (string.IsNullOrEmpty(Nome))
                AdicionarCritica("O Nome deve ser preenchido obrigatoriamente");
        }
    }
}

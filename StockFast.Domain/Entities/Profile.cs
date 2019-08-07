using System;
using System.Collections.Generic;
using System.Text;

namespace StockFast.Domain.Entities
{
    public class Profile : Entity
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public bool Ativo { get; set; }

        public override void Validate()
        {
            LimparMensagemValidacao();
            if (string.IsNullOrEmpty(Nome))
                AdicionarCritica("O Nome do Perfil deve ser preenchido obrigatoriamente");
           
            
                
        }
    }
}

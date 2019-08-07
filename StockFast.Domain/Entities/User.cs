using System;
using System.Collections.Generic;
using System.Text;

namespace StockFast.Domain.Entities
{
    public class User : Entity
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public ICollection<UserProfile> UserProfiles { get; set; }

        public override void Validate()
        {
            LimparMensagemValidacao();
            if (!UserProfile.Any())
                AdicionarCritica("O perfil de Usuário deve ser preenchido");

            if (string.IsNullOrEmpty(Login))
                AdicionarCritica("O LOGIN deve ser preenchido obrigatoriamente");

            if (string.IsNullOrEmpty(Senha))
                AdicionarCritica("A SENHA deve ser preenchida obrigatoriamente");

            if (string.IsNullOrEmpty(Nome))
                AdicionarCritica("O NOME deve ser preenchido obrigatoriamente");

            if (string.IsNullOrEmpty(Email))
                AdicionarCritica("O EMAIL deve ser preenchido obrigatoriamente");
        }
    }
}

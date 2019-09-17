using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StockFast.Domain.Entities
{
    public abstract class Entity
    {
        private List<string> _mensagensValidacao { get; set; }
        private List<string> MensagemValidacao
        {
            get { return _mensagensValidacao ?? (_mensagensValidacao = new List<string> ()); }

        }
        protected void LimparMensagemValidacao()
        {
            MensagemValidacao.Clear();
        }
        protected void AdicionarCritica(string mensagem)
        {
            MensagemValidacao.Add(mensagem);
        }
        public abstract void Validate();
        protected bool EhValido
        {
            get { return !MensagemValidacao.Any(); }
        }
    }
}

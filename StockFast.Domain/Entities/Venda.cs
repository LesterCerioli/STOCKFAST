using StockFast.Domain.ObjetodeValor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StockFast.Domain.Entities
{
    public class Venda : Entity
    {
        public int Id { get; set; }
        public DateTime DataVenda { get; set; }
        public int UsuarioId { get; set; }
        public virtual User User { get; set; }
        public DateTime DataPrevisaoEntrega { get; set; }
        public string CEP { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string Pais { get; set; }
        public string EnderecoCompleto { get; set; }
        public int NumeroEndereco { get; set; }

        public int FormaPagamentoId { get; set; }
        public virtual FormaPagamento FormaPagamento { get; set; }
        public virtual ICollection<ItemVenda> ItemVendas { get; set; }




        public virtual ICollection<ItemVenda> ItensVenda { get; set; }
        
            
        
        public override void Validate()
        {
            LimparMensagemValidacao();
            if (!ItensVenda.Any())
                AdicionarCritica("O preenchimento de Itens de venda deve ser preenchido");

            if (string.IsNullOrEmpty(CEP))
                AdicionarCritica("CEP deve ser preenchido");

            if (string.IsNullOrEmpty(Estado))
                AdicionarCritica("ESTADO deve ser preenchido");

            if (string.IsNullOrEmpty(Cidade))
                AdicionarCritica("CIDADE deve ser preenchido");

            if (string.IsNullOrEmpty(Pais))
                AdicionarCritica("PAÍS deve ser preenchido");

            if (string.IsNullOrEmpty(EnderecoCompleto))
                AdicionarCritica("O ENDEREÇO deve ser preenchido");

            if (FormaPagamentoId == 0)
                AdicionarCritica("A FORMA DE PAGAMENTO deve ser informada");







        }
    }
}

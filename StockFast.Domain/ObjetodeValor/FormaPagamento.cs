using StockFast.Domain.Enumerados;
using System;
using System.Collections.Generic;
using System.Text;

namespace StockFast.Domain.ObjetodeValor
{
    public class FormaPagamento
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }

        public bool EhBoleto
        {
            get { return Id == (int) TipoFormaPagamentoEnum.Boleto; }

        }
        public bool EhCartaoCredito
        {
            get { return Id == (int)TipoFormaPagamentoEnum.CartaoCredito; }

        }
        public bool EhCartaoDebito
        {
            get { return Id == (int)TipoFormaPagamentoEnum.CartaoDebito; }

        }
        public bool EhDeposito
        {
            get { return Id == (int)TipoFormaPagamentoEnum.Deposito; }

        }
        public bool NaoDefinido
        {
            get { return Id == (int)TipoFormaPagamentoEnum.NaoDefinido; }

        }


    }
}

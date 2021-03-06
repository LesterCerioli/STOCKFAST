﻿using System;
using System.Collections.Generic;
using System.Text;

namespace StockFast.Domain.Entities
{
    public class ProductBrand : Entity
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public bool Ativo { get; set; }
        public int ProductId { get; set; }
        public virtual ICollection<Product> Products { get; set; }
        public int ProviderId { get; set; }
        public virtual ICollection<Provider> Providers { get; set; }

        public override void Validate()
        {
            LimparMensagemValidacao();
            if (string.IsNullOrEmpty(Nome))
                AdicionarCritica("O NOME de MARCAS DE PRODUTOS deve ser preenchido obrigatoriamente");
        }
        internal static bool Any()
        {
            throw new NotImplementedException();
        }

    }
}

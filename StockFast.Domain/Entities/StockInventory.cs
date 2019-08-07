﻿using System;
using System.Collections.Generic;
using System.Text;

namespace StockFast.Domain.Entities
{
    public class StockInventory : Entity
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public int ProductId { get; set; }
        public int QuantidadeEstoque { get; set; }
        public int QuantidadeInventario { get; set; }
        public string Motivo { get; set; }
        public ICollection<Product> Products { get; set; }
        public ICollection<ProductBrand> ProductBrands { get; set; }
        public ICollection<ProductGroup> GetProductGroups { get; set; }
        public ICollection<Meansurement_Unit> Meansurement_Units { get; set; }

        public override void Validate()
        {
            LimparMensagemValidacao();
            if (string.IsNullOrEmpty(Motivo))
                AdicionarCritica("O MOTIVO deve ser preenchido obrigatoriamente");
                
        }
    }
}

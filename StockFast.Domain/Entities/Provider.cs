using System;
using System.Collections.Generic;
using System.Text;

namespace StockFast.Domain.Entities
{
    public class Provider : Entity
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string RazaoSocial { get; set; }
        public int NumeroDocumento { get; set; }
        public int Tipo { get; set; }
        public string Telefone { get; set; }
        public string Contato { get; set; }
        public string Logradouro { get; set; }
        public int Numero { get; set; }
        public string Complemento { get; set; }
        public string CEP { get; set; }
        public int CountryId { get; set; }
        public int StateId { get; set; }
        public int CityId { get; set; }
        public bool Ativo { get; set; }
        public virtual ICollection<Product> Products { get; set; }
        public virtual ICollection<ProductBrand> ProductBrands { get; set; }

        public override void Validate()
        {
            LimparMensagemValidacao();
            if (!ProductBrand.Any())
                AdicionarCritica("A Marca de Produtos deve ser preenchida obrigatoriamente");
           
        }
        internal static bool Any()
        {
            throw new NotImplementedException();
        }
        
    }
}

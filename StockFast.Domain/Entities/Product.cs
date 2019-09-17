using System;
using System.Collections.Generic;
using System.Text;

namespace StockFast.Domain.Entities
{
    public class Product : Entity
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Nome { get; set; }
        public decimal PrecoCusto { get; set; }
        public string PrecoVenda { get; set; }
        public int QuantidadeEstoque { get; set; }
        public int Meansurement_UnitId { get; set; }
        public int GroupId { get; set; }
        public int ProductBrandId { get; set; }
        public int ProviderId { get; set; }
        public int LocalStorageId { get; set; }
        public bool Ativo { get; set; }
        public string Imagem { get; set; }
        public virtual ICollection<ProductBrand> ProductBrands { get; set; }
        public virtual ICollection<ProductGroup> ProductGroups { get; set; }
        public virtual ICollection<Provider> Providers { get; set; }
        public virtual ICollection<State> States { get; set; }
        public virtual ICollection<Country> Countries { get; set; }
        public virtual ICollection<City> Cities { get; set; }
        public virtual ICollection<ProductEntry> GetProductEntries { get; set; }
        public virtual ICollection<ExitProduct> ExitProducts { get; set; }

        public override void Validate()
        {
            
            LimparMensagemValidacao();
            if (!ProductBrand.Any())
                AdicionarCritica("O preenchimento de marca de Produtos é obrigatório");


            if (!ProductGroup.Any())
                AdicionarCritica("O preenchimento do Grupo de Produtos é obrigatório");

            if (!Provider.Any())
                AdicionarCritica("O preenchimento de Fornecedores é obrigatório");

            if (!State.Any())
                AdicionarCritica("O preenchimento do Estado é obrigatório");

            if (!Country.Any())
                AdicionarCritica("Oprenchimento de País é obrigatório");

            if (!City.Any())
                AdicionarCritica("O preenchimento de Cidade é obrigatório");

            if (string.IsNullOrEmpty(Codigo))
                AdicionarCritica("O Código dos Produtos deve ser preenchido obrigatoriamente");

            if (string.IsNullOrEmpty(Nome))
                AdicionarCritica("O NOME dos Produtos deve ser preenchido obrigatoriamente");
            
            //if (string.IsNullOrEmpty(CEP))
            AdicionarCritica("O CEP deve ser preenchido obrigatoriamente");

            

        }
    }
}

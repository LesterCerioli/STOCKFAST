using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;
using StockFast.Domain.Entities;
using StockFast.Repository.Config;
using System;
using System.Collections.Generic;
using System.Text;
using UserProfile = StockFast.Repository.Config.UserProfile;

namespace StockFast.Repository.Context
{
    public class StockFastContext : DbContext
    {
        

        public DbSet<City>  Cities { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<ExitProduct> ExitProducts { get; set; }
        public DbSet<ProductGroup> ProductGroups { get; set; }
        public DbSet<Local_Storage> Local_Storages { get; set; }
        public DbSet<Meansurement_Unit> Meansurement_Units { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductBrand> ProductBrands { get; set; }
        public DbSet<ProductEntry> ProductEntries { get; set; }
        public DbSet<Profile> Profiles { get; set; }
        public DbSet<Provider> Providers { get; set; }
        public DbSet<State> States { get; set; }
        public DbSet<StockInventory> StockInventories { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserProfile> UserProfiles { get; set; }
        public DbSet<Venda> Vendas { get; set; }
        public DbSet<ItemVenda> ItemVendas { get; set; }

        public StockFastContext(DbContextOptions options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //mapping classes
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new UserProfile());
            modelBuilder.ApplyConfiguration(new VendaConfiguration());
            modelBuilder.ApplyConfiguration(new StockInventoryConfiguration());
            modelBuilder.ApplyConfiguration(new StateConfiguration());
            modelBuilder.ApplyConfiguration(new ProviderConfiguration());
            modelBuilder.ApplyConfiguration(new ProfileConfiguration());
            modelBuilder.ApplyConfiguration(new ProductGroupConfiguration());
            modelBuilder.ApplyConfiguration(new ProductEntryConfiguration());
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            modelBuilder.ApplyConfiguration(new ProductBrandConfiguration());
            modelBuilder.ApplyConfiguration(new Meansurement_UnitConfiguration());
            modelBuilder.ApplyConfiguration(new Local_StorageConfiguration());
            modelBuilder.ApplyConfiguration(new ItemVendaConfiguration());
            modelBuilder.ApplyConfiguration(new FormaPagamentoConfiguration());
            modelBuilder.ApplyConfiguration(new ExitProductConfiguration());
            modelBuilder.ApplyConfiguration(new CountryConfiguration());
            modelBuilder.ApplyConfiguration(new CityConfiguration());



            base.OnModelCreating(modelBuilder);
        }

    }
}

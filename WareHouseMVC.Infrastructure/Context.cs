using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WareHouseMVC.Domain.Model;

namespace WareHouseMVC.Infrastructure
{
    public class Context : IdentityDbContext
    {
        public DbSet<ContactDetailType> ContactDetailsType { get; set; }

        public DbSet<CustomerAddress> CustomerAddresses { get; set; }
        public DbSet<CustomerContactDetail> CustomerContactDetails { get; set; }
        public DbSet<CustomerContactInformation> CustomerContactInformation { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<ProviderAddress> ProviderAddresses { get; set; }
        public DbSet<ProviderContactDetail> ProviderContactDetails { get; set; }
        public DbSet<ProviderContactInformation> ProviderContactInformation { get; set; }
        public DbSet<Provider> Providers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductTag> ProductTag { get; set; }
        
        public DbSet<Tag> Tags { get; set; }
        public DbSet<WareHouseMVC.Domain.Model.Type> Types { get; set; }

        public Context(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Customer>()
                .HasOne(a => a.CustomerContactInformation).WithOne(b => b.Customer)
                .HasForeignKey<CustomerContactInformation>(e => e.CustomerRef);

            builder.Entity<Provider>()
                .HasOne(a => a.ProviderContactInformation).WithOne(b => b.Provider)
                .HasForeignKey<ProviderContactInformation>(e => e.ProviderRef);
            

            builder.Entity<ProductTag>()
                .HasKey(it => new { it.ProductId, it.TagId });

            builder.Entity<ProductTag>()
                .HasOne<Product>(it => it.Product)
                .WithMany(i => i.ProductTags)
                .HasForeignKey(it => it.ProductId);

            builder.Entity<ProductTag>()
                .HasOne<Tag>(it => it.Tag)
                .WithMany(t => t.ProductTags)
                .HasForeignKey(it => it.TagId);

        }
    }
    

}


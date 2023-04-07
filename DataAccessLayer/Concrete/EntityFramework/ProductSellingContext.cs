using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Concrete.EntityFramework.Mapping;
using EntityLayer.Concrete;

namespace DataAccessLayer.Concrete.EntityFramework
{
    public class ProductSellingContext:DbContext
    {
        public ProductSellingContext()
        {
            Database.SetInitializer<ProductSellingContext>(null);
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<DiscountType> DiscountTypes { get; set; }
        public DbSet<Category> Categories { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new EfProductMapping());
            modelBuilder.Configurations.Add(new EfDiscountTypeMapping());
            modelBuilder.Configurations.Add(new EfCategoryMapping());
        }
    }
}

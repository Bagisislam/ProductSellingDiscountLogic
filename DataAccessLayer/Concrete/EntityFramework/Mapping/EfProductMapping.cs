using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer.Concrete;

namespace DataAccessLayer.Concrete.EntityFramework.Mapping
{
    public class EfProductMapping:EntityTypeConfiguration<Product>
    {
        public EfProductMapping()
        {
            ToTable(@"Products", @"dbo");

            HasKey(t=>t.ProductId);

            Property(t => t.ProductId).HasColumnName(@"Id");
            Property(t => t.IsDeleted).HasColumnName(@"IsDeleted");
            Property(t => t.CategoryId).HasColumnName(@"CategoryId");
            Property(t => t.IsDiscount).HasColumnName(@"IsDiscount");
            Property(t => t.ProductName).HasColumnName(@"ProductName");
            Property(t => t.UnitInStock).HasColumnName(@"UnitInStock");
            Property(t => t.UnitPrice).HasColumnName(@"UnitPrice");
        }
    }
}

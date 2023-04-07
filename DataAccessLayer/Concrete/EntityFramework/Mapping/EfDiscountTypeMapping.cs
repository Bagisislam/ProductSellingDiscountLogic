using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer.Concrete;

namespace DataAccessLayer.Concrete.EntityFramework.Mapping
{
    public class EfDiscountTypeMapping:EntityTypeConfiguration<DiscountType>
    {
        public EfDiscountTypeMapping()
        {
            ToTable(@"DiscountTypes",@"dbo");

            HasKey(t => t.Id);

            Property(t => t.Id).HasColumnName(@"Id");
            Property(t => t.DiscountAmount).HasColumnName(@"DiscountAmount");
            Property(t => t.DiscountIsDeleted).HasColumnName(@"DiscountIsDeleted");
            Property(t => t.DiscountName).HasColumnName(@"DiscountName");
        }
    }
}

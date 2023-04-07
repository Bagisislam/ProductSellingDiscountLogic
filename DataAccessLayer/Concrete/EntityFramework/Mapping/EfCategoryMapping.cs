using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer.Concrete;

namespace DataAccessLayer.Concrete.EntityFramework.Mapping
{
    public class EfCategoryMapping:EntityTypeConfiguration<Category>
    {
        public EfCategoryMapping()
        {
            ToTable(@"Categorys", @"dbo");

            HasKey(h => h.Id);

            Property(p => p.Id).HasColumnName(@"Id");
            Property(p => p.CategoryName).HasColumnName(@"CategoryName");
            Property(p => p.CategoryId).HasColumnName(@"CategoryId");
            Property(p => p.IsDeleted).HasColumnName(@"IsDeleted");

        }
    }
}

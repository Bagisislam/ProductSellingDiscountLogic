using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.ComplexType;
using EntityLayer.Concrete;

namespace DataAccessLayer.Concrete.EntityFramework
{
    public class ProductDal:EntityRepository<Product,ProductSellingContext>,IProductDal
    {
        public List<ProductDetail> getProductDetails()
        {
            using (var context = new ProductSellingContext())
            {
                var result = from p in context.Products
                    join c in context.Categories on p.CategoryId equals c.CategoryId
                    select new ProductDetail()
                    {
                        ProductId = p.ProductId,
                        CategoryName = c.CategoryName,
                        ProductName = p.ProductName,
                        UnitPrice = p.UnitPrice,
                        UnitInStock = p.UnitInStock,
                        IsDeleted = p.IsDeleted,
                        IsDiscount = p.IsDiscount,
                        CategoryId = c.CategoryId
                    };
                return result.ToList();
            }
        }
    }
}

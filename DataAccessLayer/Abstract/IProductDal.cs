using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Abstract;
using DataAccessLayer.ComplexType;
using EntityLayer.Concrete;

namespace DataAccessLayer.Abstract
{
    public interface IProductDal:IEntityRepository<Product>
    {
        List<ProductDetail> getProductDetails();
    }
}

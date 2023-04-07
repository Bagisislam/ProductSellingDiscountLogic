using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.ComplexType;
using EntityLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Abstract
{
    public interface IProductMeneger
    {
        List<ProductDetail> GetAll();
    }
}

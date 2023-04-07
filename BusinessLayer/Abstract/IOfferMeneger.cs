using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.ComplexType;
using EntityLayer.Concrete;

namespace BusinessLayer.Abstract
{
    public interface IOfferMeneger
    {
        List<ProductDetail> UpdatePrice(List<ProductDetail> product, string CategoryType = null);
    }
}

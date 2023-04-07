using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Abstract;
using DataAccessLayer.ComplexType;
using DataAccessLayer.Concrete.EntityFramework;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class ProductMeneger : IProductMeneger
    {
        private ProductDal _productDal;
        private IOfferMeneger _offerMeneger;
        public ProductMeneger(ProductDal productDal, IOfferMeneger offerMeneger)
        {
            _productDal = productDal;
            _offerMeneger = offerMeneger;
        }

        public List<ProductDetail> GetAll()
        {
            List<ProductDetail> getAll = _productDal.getProductDetails();

            var offer = _offerMeneger.UpdatePrice(getAll,"1");

            return offer;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.ComplexType;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class StandardPrice : IOfferMeneger
    {
        private IDiscountTypeDal _discountTypeDal;
        public StandardPrice(IDiscountTypeDal discountTypeDal)
        {
            _discountTypeDal = discountTypeDal;
        }

        public List<ProductDetail> UpdatePrice(List<ProductDetail> product ,string CategoryType = null)
        {
            foreach (var VARIABLE in product)
            {
                if (VARIABLE.IsDeleted == false && VARIABLE.IsDiscount && VARIABLE.CategoryId == Convert.ToInt32(CategoryType))
                {
                    VARIABLE.UnitPrice = GetbyStandardPrice();
                }
            }

            return product;
        }

        private decimal GetbyStandardPrice()
        {
            decimal hello = 0;
            foreach (var VARIABLE in _discountTypeDal.GetAll(t => t.Id == 1 && t.DiscountIsDeleted == false))
            {
                hello = VARIABLE.DiscountAmount;
            }

            return hello;
        }
    }
}

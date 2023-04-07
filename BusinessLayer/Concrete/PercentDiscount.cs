using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.ComplexType;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class PercentDiscount : IOfferMeneger
    {
        private IDiscountTypeDal _discountTypeDal;
        public PercentDiscount(IDiscountTypeDal discountTypeDal)
        {
            _discountTypeDal = discountTypeDal;
        }
        public List<ProductDetail> UpdatePrice(List<ProductDetail> product, string CategoryType = null)
        {
            foreach (var VARIABLE in product)
            {
                if (VARIABLE.IsDeleted == false && VARIABLE.IsDiscount && VARIABLE.CategoryId == Convert.ToInt32(CategoryType))
                {
                    VARIABLE.UnitPrice = GetbyPercentPrice(VARIABLE.UnitPrice);
                }
            }

            return product;
        }

        private decimal GetbyPercentPrice(decimal unitPrice)
        {
            decimal hello = 0;
            foreach (var VARIABLE in _discountTypeDal.GetAll(t => t.Id == 2 && t.DiscountIsDeleted == false))
            {
                hello = unitPrice - (unitPrice * VARIABLE.DiscountAmount / 100);
            }

            return hello;
        }
    }
}

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
    public class DiscountTypeDal:EntityRepository<DiscountType,ProductSellingContext>,IDiscountTypeDal
    {
       
    }
}

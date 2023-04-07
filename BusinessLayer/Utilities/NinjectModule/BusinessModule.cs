using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.EntityFramework;
using Ninject.Modules;
using Ninject.Planning.Bindings.Resolvers;

namespace BusinessLayer.Utilities.NinjectModule
{
    public class BusinessModule:Ninject.Modules.NinjectModule
    {
        public override void Load()
        {
            Bind<IProductMeneger>().To<ProductMeneger>().InSingletonScope();
            Bind<IProductDal>().To<ProductDal>().InSingletonScope();
            Bind<IOfferMeneger>().To<PercentDiscount>().InSingletonScope();
            Bind<IDiscountTypeDal>().To<DiscountTypeDal>().InSingletonScope();
        }
    }
}

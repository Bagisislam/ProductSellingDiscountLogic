using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;

namespace BusinessLayer.Utilities.NinjectModule
{
    public  class InstanceFactory
    {
        public static T GetInstance<T>()
        {
            IKernel standartKernal = new StandardKernel(new BusinessModule());

            return standartKernal.Get<T>();
        }
    }
}

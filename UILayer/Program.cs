using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using BusinessLayer.Utilities.NinjectModule;
using DataAccessLayer.Concrete.EntityFramework;
using EntityLayer.Concrete;

namespace UILayer
{
    public class Program
    {
        static void Main(string[] args)
        {
            IProductMeneger hello = InstanceFactory.GetInstance<IProductMeneger>();

            foreach (var VARIABLE in hello.GetAll())
            {
                Console.WriteLine($"ProductName = {VARIABLE.ProductName} ----- " +
                                  $"CategoryId = {VARIABLE.CategoryId} ------- " +
                                  $"UnitPrice = {VARIABLE.UnitPrice} -------- " +
                                  $"UnitInStock = {VARIABLE.UnitInStock} ------- " +
                                  $"IsDeleted = {VARIABLE.IsDeleted} ------- " +
                                  $"IsDiscount = {VARIABLE.IsDiscount} ------- "+
                                  $"CategoryName = {VARIABLE.CategoryName}");

                Console.WriteLine("*****************************");
            }


            Console.ReadLine();
        }
    }
}

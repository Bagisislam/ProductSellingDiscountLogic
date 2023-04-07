using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.ComplexType
{
    public class ProductDetail
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public int UnitInStock { get; set; }
        public string CategoryName { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsDiscount { get; set; }
    }
}

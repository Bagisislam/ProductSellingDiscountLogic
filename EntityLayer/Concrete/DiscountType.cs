using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer.Abstract;

namespace EntityLayer.Concrete
{
    public class DiscountType:IEntity
    {
        public int Id { get; set; }
        public string DiscountName { get; set; }
        public decimal DiscountAmount { get; set; }
        public bool DiscountIsDeleted { get; set; }
    }
}

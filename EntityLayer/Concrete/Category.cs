using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer.Abstract;

namespace EntityLayer.Concrete
{
    public class Category:IEntity
    {
         public int Id { get; set; }
         public int CategoryId { get; set;}
         public string CategoryName { get; set; }
         public byte IsDeleted { get; set; }
    }
}

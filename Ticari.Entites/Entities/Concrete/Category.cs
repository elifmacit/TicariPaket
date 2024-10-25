using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ticari.Entities.Entities.Abstract;

namespace Ticari.Entities.Entities.Concrete
{
    public class Category :BaseEntity
    {
        public string CategoryName { get; set; }
        public string? Description { get; set; }
        public ICollection<Product>? Products { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ticari.Entities.Entities.Abstract;

namespace Ticari.Entities.Entities.Concrete
{
    public class Product:BaseEntity
    {
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public string? Description { get; set; }

        public decimal? UnitPrice { get; set; }

        public decimal? Amount { get; set; }
        public ICollection<Category>? Categories { get; set; }
    }
}

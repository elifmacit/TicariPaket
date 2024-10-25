using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ticari.Entities.Entities.Abstract;

namespace Ticari.Entities.Entities.Concrete
{
    public class Gsm116 :BaseEntity
    {
        public string TcNo { get; set; }
        public string Gsm { get; set; }
    }
}

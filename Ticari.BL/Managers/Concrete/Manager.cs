using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ticari.BL.Managers.Abstract;
using Ticari.DAL.GenericRepository.EfCore.Concrete;
using Ticari.Entities.Entities.Abstract;

namespace Ticari.BL.Managers.Concrete
{
    public class Manager<T> :Repository<T>, IManager<T> where T : BaseEntity
    {
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ticari.DAL.GenericRepository.EfCore.Abstract;
using Ticari.Entities.Entities.Abstract;

namespace Ticari.BL.Managers.Abstract
{
    public interface IManager<T> :IRepository<T> where T : BaseEntity
    {
    }
}

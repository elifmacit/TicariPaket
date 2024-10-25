using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ticari.Entities.Entities.Abstract;

namespace Ticari.Entities.Entities.Concrete
{
    public class Menu:BaseEntity
    {
        public string MenuName {  get; set; }
        public string? ActionName { get; set; }
        public string? ControllerName { get; set; }
        public string? AreaName { get; set; }
        public string? ClassName {  get; set; }
        public string? CssName {  get; set; }
        public string? IConName { get; set; }
        public int? OrderNo { get; set; }
        
        public int? ParentMenuId { get; set; }
        public Menu? ParentMenu { get; set; }
        
        public int? RoleId { get; set; }
        public Role Role { get; set; }
    }
}

using FSharp.Data.Runtime.StructuralTypes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_DynamicMenu.Models
{
    public class UserPermission
    {
        [Key]
        public int PermissionId { get; set; } 
        public String MenuItem { get; set; } 
        public int Permission { get; set; } 
        public Users Users { get; set; } 
    }
}

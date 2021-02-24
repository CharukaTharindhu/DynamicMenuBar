using FSharp.Data.Runtime.StructuralTypes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_DynamicMenu.Models
{
    public class Users
    {
        [Key]
        public int UserId { get; set; }
        public String Name { get; set; } 
        public String Role { get; set; }

        public ICollection<Users> UserPermission { get; set; }

       
    }
}

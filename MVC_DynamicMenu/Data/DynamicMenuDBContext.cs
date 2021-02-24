using Microsoft.EntityFrameworkCore;
using MVC_DynamicMenu.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_DynamicMenu.Data
{
    public class DynamicMenuDBContext:DbContext
    {
        public DynamicMenuDBContext(DbContextOptions<DynamicMenuDBContext> option) : base(option)
        {

        }
        public DbSet<Users> Users { get; set; }
        public DbSet<UserPermission> UserPermission { get; set; }
    }
}

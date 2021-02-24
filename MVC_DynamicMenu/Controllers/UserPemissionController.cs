using Microsoft.AspNetCore.Mvc;
using MVC_DynamicMenu.Data;
using MVC_DynamicMenu.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_DynamicMenu.Controllers
{
    public class UserPemissionController : Controller
    {
        private readonly DynamicMenuDBContext _context;
        public UserPemissionController(DynamicMenuDBContext context)
        {
            _context = context; 
        }
        public IActionResult Index() 
        {
            var objList = _context.UserPermission.ToList(); 
            return View(objList);
        }
    }
}

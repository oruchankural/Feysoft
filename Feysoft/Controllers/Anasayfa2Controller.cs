using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Feysoft.Controllers
{
    public class Anasayfa2Controller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
       
    }
}
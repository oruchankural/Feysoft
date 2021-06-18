using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Feysoft.Controllers
{
    public class HizmetlerController : Controller
    {
        public IActionResult Index()
        {
            
            return View();
        }
        public IActionResult eBA()
        {

            return View();
        }
        public IActionResult HizmetDetay()
        {

            return View();
        }
    }
}
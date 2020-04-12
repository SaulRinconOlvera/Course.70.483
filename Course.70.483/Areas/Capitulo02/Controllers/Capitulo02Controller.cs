using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Course._70._483.Areas.Capitulo02.Controllers
{
    [Area("Capitulo02")]
    public class Capitulo02Controller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
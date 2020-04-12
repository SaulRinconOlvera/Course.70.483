using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Course._70._483.Areas.Capitulo04.Controllers
{
    [Area("Capitulo04")]
    public class Capitulo04Controller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
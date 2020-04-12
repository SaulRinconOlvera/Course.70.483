using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Course._70._483.Areas.Capitulo03.Controllers
{
    [Area("Capitulo03")]
    public class Capitulo03Controller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
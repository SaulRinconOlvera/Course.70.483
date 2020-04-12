using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Course._70._483.Areas.Capitulo01.Controllers
{
    public class Tema0105Controller : Controller
    {
        [Area("Capitulo01")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
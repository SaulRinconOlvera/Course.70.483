using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Course._70._483.Areas.Capitulo01.Controllers.Capitulo01.Tema02
{
    public class Tema0202Controller : Controller
    {
        [Area("Capitulo01")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
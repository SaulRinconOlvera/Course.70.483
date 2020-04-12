using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Course._70._483.Areas.Capitulo01.Controllers
{
    [Area("Capitulo01")]
    public class Tema0102Controller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
using Microsoft.AspNetCore.Mvc;

namespace Course._70._483.Areas.Capitulo01.Controllers.Capitulo01.Tema05
{
    public class Tema0506Controller : Controller
    {
        [Area("Capitulo01")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
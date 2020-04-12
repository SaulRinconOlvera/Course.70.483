using Microsoft.AspNetCore.Mvc;

namespace Course._70._483.Areas.Capitulo01.Controllers.Capitulo01.Tema02
{
    [Area("Capitulo01")]
    public class Tema02Controller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
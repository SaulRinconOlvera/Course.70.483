using Microsoft.AspNetCore.Mvc;

namespace Course._70._483.Areas.Capitulo01.Controllers
{
    [Area("Capitulo01")]
    public class Tema0103Controller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
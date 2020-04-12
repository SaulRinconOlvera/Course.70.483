using Microsoft.AspNetCore.Mvc;

namespace Course._70._483.Areas.Capitulo01.Controllers.Capitulo01.Test
{
    [Area("Capitulo01")]
    public class Test01Controller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
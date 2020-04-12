using Microsoft.AspNetCore.Mvc;

namespace Course._70._483.Areas.Capitulo01.Controllers.Capitulo01.Test
{
    public class Test01AnswersController : Controller
    {
        [Area("Capitulo01")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
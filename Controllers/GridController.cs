using Microsoft.AspNetCore.Mvc;

namespace TestTaskOnSea.Controllers
{
    public class GridController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult PlayGame()
        {
            return View();
        }
    }
}

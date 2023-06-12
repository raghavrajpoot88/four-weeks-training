using Microsoft.AspNetCore.Mvc;

namespace DemoApplication.Controllers
{
    public class TaskController : Controller
    {
        [Route("/")]
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }
        public IActionResult Update()
        {
            return View();
        }
        public IActionResult Search()
        {
            return View();

        }

    }
}

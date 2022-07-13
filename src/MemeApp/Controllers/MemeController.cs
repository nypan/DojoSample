using Microsoft.AspNetCore.Mvc;

namespace MemeApp.Controllers
{
    public class MemeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public MemeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}

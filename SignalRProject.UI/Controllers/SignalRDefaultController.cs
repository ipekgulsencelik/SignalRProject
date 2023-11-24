using Microsoft.AspNetCore.Mvc;

namespace SignalRProject.UI.Controllers
{
    public class SignalRDefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CountCategory()
        {
            return View();
        }
    }
}

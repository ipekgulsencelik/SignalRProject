using Microsoft.AspNetCore.Mvc;

namespace SignalRProject.UI.Controllers
{
    public class AdminLayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
using Microsoft.AspNetCore.Mvc;

namespace SignalRProject.UI.Controllers
{
    public class StatisticController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

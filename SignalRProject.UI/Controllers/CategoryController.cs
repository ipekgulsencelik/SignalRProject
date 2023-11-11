using Microsoft.AspNetCore.Mvc;

namespace SignalRProject.UI.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
using Microsoft.AspNetCore.Mvc;

namespace SignalRProject.UI.ViewComponents.LayoutComponents
{
    public class _LayoutScriptPartialComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
using Microsoft.AspNetCore.Mvc;

namespace GuideUI.Controllers
{
    public class WebsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

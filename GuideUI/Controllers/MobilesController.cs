using Microsoft.AspNetCore.Mvc;

namespace GuideUI.Controllers
{
    public class MobilesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

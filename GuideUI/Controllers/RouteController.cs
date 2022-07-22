using Microsoft.AspNetCore.Mvc;

namespace GuideUI.Controllers
{
    public class RouteController : Controller
    {
        public IActionResult Index()
        {
            return Redirect("tr/cihaz/iklimlendirme");
        }
    }
}

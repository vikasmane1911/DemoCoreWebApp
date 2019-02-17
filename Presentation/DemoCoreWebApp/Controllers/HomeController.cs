using Microsoft.AspNetCore.Mvc;

namespace DemoCoreWebApp.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

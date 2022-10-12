using Microsoft.AspNetCore.Mvc;

namespace CmosWeb.Areas.Requestment.Controllers
{
    [Area("Requestment")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

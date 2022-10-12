using Microsoft.AspNetCore.Mvc;

namespace CmosWeb.Areas.Requestment.Controllers
{
    [Area("Requestment")]
    public class OutboundController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

using Microsoft.AspNetCore.Mvc;

namespace CmosWeb.Areas.Requestment.Controllers
{
    [Area("Requestment")]
    public class InboundController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

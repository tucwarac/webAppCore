using Microsoft.AspNetCore.Mvc;

namespace CmosWeb.Areas.Requestment.Controllers
{
    [Area("Requestment")]
    public class ReportController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

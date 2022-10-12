using Microsoft.AspNetCore.Mvc;

namespace WebAppCore.Areas.Administrator.Controllers
{
    [Area("Administrator")]
    public class SettingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

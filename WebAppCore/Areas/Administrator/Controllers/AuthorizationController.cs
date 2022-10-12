using Microsoft.AspNetCore.Mvc;

namespace WebAppCore.Areas.Administrator.Controllers
{
    [Area("Administrator")]
    public class AuthorizationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

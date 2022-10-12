using WebAppCore.Helpers.Home;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace WebAppCore.Controllers
{
    public class HomeController : Controller
    {
        //private readonly ILogger<HomeController> _logger;

        ////public const string SessionMenuList = "_Menu";

        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}

        public async Task<IActionResult> Index()
        {
            var model = await new HomeHelper().HomeGetModel();

            IActionResult result;

            switch (model.HomeDynamicModelIdChoosed)
            {
                case 1:
                    result = View(model);
                    break;
                case 2:
                    result = RedirectToAction("Index", "Home", new { area = "Requestment" });
                    break;
                default:
                    result = View();
                    break;
            }

            return result;
        }

        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //public IActionResult Error()
        //{
        //    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        //}
    }
}
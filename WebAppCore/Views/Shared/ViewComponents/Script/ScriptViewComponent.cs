using Microsoft.AspNetCore.Mvc;

namespace WebAppCore.Views.Shared.ViewComponents.Script
{
    public class ScriptViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {

            return View();
        }
    }
}

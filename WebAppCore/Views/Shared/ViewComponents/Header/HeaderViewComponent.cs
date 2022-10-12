using Microsoft.AspNetCore.Mvc;

namespace WebAppCore.Views.Shared.ViewComponents.Header
{
    public class HeaderViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {

            return View();
        }
    }
}

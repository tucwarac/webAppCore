using Microsoft.AspNetCore.Mvc;

namespace WebAppCore.Views.Shared.ViewComponents.Css
{
    public class CssViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {

            return View();
        }
    }
}

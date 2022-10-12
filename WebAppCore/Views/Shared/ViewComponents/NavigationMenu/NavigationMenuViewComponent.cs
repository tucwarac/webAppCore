using WebAppCore.Helpers.Home;
using Microsoft.AspNetCore.Mvc;

namespace WebAppCore.Views.Shared.ViewComponents.NavigationMenu
{
    public class NavigationMenuViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var model = await new HomeHelper().NavigationMenuGet();

            return View(model);
        }
    }
}

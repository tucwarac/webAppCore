using WebAppCore.Helpers.Home;
using Microsoft.AspNetCore.Mvc;

namespace WebAppCore.Views.Shared.ViewComponents.Breadcrumb
{
    public class BreadcrumbViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            //var model = await new BreadcrumbHelper().BreadcrumbGet();

            return View();
        }
    }
}

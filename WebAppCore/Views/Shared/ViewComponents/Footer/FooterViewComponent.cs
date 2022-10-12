using Microsoft.AspNetCore.Mvc;

namespace WebAppCore.Views.Shared.ViewComponents.Footer
{
    public class FooterViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {

            return View();
        }
    }
}

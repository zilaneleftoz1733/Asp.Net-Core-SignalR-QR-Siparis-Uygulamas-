using Microsoft.AspNetCore.Mvc;
namespace SignalRWebUI.ViewComponents.LayoutComponents
{
    public class _LayoutHeaderPartialComponent : ViewComponent
    {
        public IViewComponentResult Invoke() //buranın viewcomponent oldugunu bildirmiş olduk
        {
            return View();
        }
    }
}

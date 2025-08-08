using Microsoft.AspNetCore.Mvc;


namespace ApiProjeKampi.WEBUI.ViewComponents
{
    public class _NavbarDefaultComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}

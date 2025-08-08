using Microsoft.AspNetCore.Mvc;

namespace ApiProjeKampi.WEBUI.ViewComponents
{
    public class _AboutDefaultComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}

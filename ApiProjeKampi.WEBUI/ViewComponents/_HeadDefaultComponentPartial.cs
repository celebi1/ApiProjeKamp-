using Microsoft.AspNetCore.Mvc;

namespace ApiProjeKampi.WEBUI.ViewComponents
{
    public class _HeadDefaultComponentPartial :ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}

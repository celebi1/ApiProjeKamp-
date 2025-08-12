using Microsoft.AspNetCore.Mvc;

namespace ApiProjeKampi.WEBUI.ViewComponents
{
    public class _FooterDefaultComponentPartial :ViewComponent
    {
        public IViewComponentResult Invoke() {  return View(); }
    }
}

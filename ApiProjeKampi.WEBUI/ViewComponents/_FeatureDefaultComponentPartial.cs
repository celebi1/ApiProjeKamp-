using Microsoft.AspNetCore.Mvc;

namespace ApiProjeKampi.WEBUI.ViewComponents
{
    public class _FeatureDefaultComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
    

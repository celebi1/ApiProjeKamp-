using Microsoft.AspNetCore.Mvc;

namespace ApiProjeKampi.WEBUI.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

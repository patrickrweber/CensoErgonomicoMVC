using Microsoft.AspNetCore.Mvc;

namespace CensoErgonomico.WebApp.Controllers
{
    public class IMCController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

using Microsoft.AspNetCore.Mvc;

namespace CensoErgonomico.WebApp.Controllers
{
    public class CensoErgonomicoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

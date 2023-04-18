using Microsoft.AspNetCore.Mvc;

namespace CensoErgonomico.WebApp.Controllers
{
    public class LocaisDoresController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

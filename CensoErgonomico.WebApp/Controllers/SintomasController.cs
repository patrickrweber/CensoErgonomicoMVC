using Microsoft.AspNetCore.Mvc;

namespace CensoErgonomico.WebApp.Controllers
{
    public class SintomasController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

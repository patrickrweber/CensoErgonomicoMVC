using Microsoft.AspNetCore.Mvc;

namespace CensoErgonomico.WebApp.Controllers
{
    public class AcoesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

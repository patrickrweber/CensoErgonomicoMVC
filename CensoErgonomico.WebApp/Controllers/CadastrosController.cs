using Microsoft.AspNetCore.Mvc;

namespace CensoErgonomico.WebApp.Controllers
{
    public class CadastrosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

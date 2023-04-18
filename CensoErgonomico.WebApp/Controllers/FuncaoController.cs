using Microsoft.AspNetCore.Mvc;

namespace CensoErgonomico.WebApp.Controllers
{
    public class FuncaoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

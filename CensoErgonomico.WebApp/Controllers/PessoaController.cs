using Microsoft.AspNetCore.Mvc;

namespace CensoErgonomico.WebApp.Controllers
{
    public class PessoaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

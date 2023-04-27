using CensoErgonomico.Domain.Interfaces.Repositories;
using CensoErgonomico.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace CensoErgonomico.WebApp.Controllers
{
    public class SetorController : Controller
    {
        private readonly ISetorRepository _setorRepository;

        public SetorController(ISetorRepository setorRepository)
        {
            _setorRepository= setorRepository;
        }
        public IActionResult Index()
        {
            return PartialView("~/Views/Setor/Index.cshtml");
        }

        [HttpPost]
        public IActionResult Create(Setor setor)
        {
            if (ModelState.IsValid)
            {
                _setorRepository.Save(setor);
                TempData["Success"] = "Salvo com sucesso";
                return RedirectToAction("Index", "Cadastros");
            }
            return RedirectToAction("Index", "Cadastros");
        }
    }
}

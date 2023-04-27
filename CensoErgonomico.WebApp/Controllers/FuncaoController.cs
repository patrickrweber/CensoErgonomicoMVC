using CensoErgonomico.Domain.Interfaces.Repositories;
using CensoErgonomico.Domain.Models;
using CensoErgonomico.Infra.Data.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CensoErgonomico.WebApp.Controllers
{
    public class FuncaoController : Controller
    {
        private readonly IFuncaoRepository _funcaoRepository;
        private readonly ISetorRepository _setorRepository;

        public FuncaoController(ISetorRepository setorRepository, IFuncaoRepository funcaoRepository)
        {
            _setorRepository= setorRepository;
            _funcaoRepository = funcaoRepository;
        }
        public IActionResult Index()
        {
            ViewBag.setorId = new SelectList(_setorRepository.GetAll(), "id", "name", "Select...");
            return PartialView("~/Views/Funcao/Create.cshtml");
        }

        [HttpPost]
        public IActionResult Create(Funcao funcao)
        {
            if (ModelState.IsValid)
            {
                _funcaoRepository.Save(funcao);
                TempData["Success"] = "Salvo com sucesso";
                return RedirectToAction("Index", "Cadastros");
            }
            return RedirectToAction("Index", "Cadastros");
        }
    }
}

using CensoErgonomico.Domain.DTOs;
using CensoErgonomico.Domain.Interfaces.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace CensoErgonomico.WebApp.Controllers
{
    public class PessoaController : Controller
    {
        private readonly IPessoaRepository _pessoaRepository;

        public PessoaController(IPessoaRepository pessoaRepository)
        {
            _pessoaRepository = pessoaRepository;
        }
        public IActionResult Index()
        {
            return PartialView("~/Views/Pessoa/Create.cshtml");
        }

        [HttpPost]
        public IActionResult Create(PessoaDTO pessoaDTO)
        {
            if (ModelState.IsValid)
            {
                _pessoaRepository.Save(pessoaDTO.MapToEntity(pessoaDTO));
                TempData["Success"] = "Salvo com sucesso";
                return RedirectToAction("Index", "Cadastros");
            }
            return RedirectToAction("Index", "Cadastros");
        }
    }
}

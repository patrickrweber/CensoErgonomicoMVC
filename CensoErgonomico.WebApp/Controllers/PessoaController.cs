using CensoErgonomico.Domain.DTOs;
using CensoErgonomico.Domain.Interfaces.Repositories;
using CensoErgonomico.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace CensoErgonomico.WebApp.Controllers
{
    public class PessoaController : Controller
    {
        private readonly IPessoaRepository _pessoaRepository;
        private readonly IIMCRepository _IMCRepository;

        public PessoaController(IPessoaRepository pessoaRepository, IIMCRepository IMCRepository)
        {
            _pessoaRepository = pessoaRepository;
            _IMCRepository = IMCRepository;
        }
        public IActionResult Index()
        {
            return PartialView("~/Views/Pessoa/Index.cshtml");
        }

        [HttpPost]
        public IActionResult Create(PessoaLinks pessoaIMC)
        {

            if (ModelState.IsValid)
            {
                Pessoa pessoa = pessoaIMC.MapToPessoaEntity(pessoaIMC);
                _pessoaRepository.Save(pessoa);

                IMC IMC = pessoaIMC.MapToIMCEntity(pessoaIMC, pessoa.Id);
                _IMCRepository.Save(IMC);

                TempData["Success"] = "Salvo com sucesso";
            }

            return RedirectToAction("Index", "Cadastros");
        }
    }
}

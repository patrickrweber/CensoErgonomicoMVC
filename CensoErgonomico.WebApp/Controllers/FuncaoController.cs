using CensoErgonomico.Domain.DTOs;
using CensoErgonomico.Domain.Interfaces.Repositories;
using CensoErgonomico.Domain.Models;
using CensoErgonomico.Infra.Data.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

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
            SetorDTO setorDTO = new SetorDTO();
            ViewBag.setores = _setorRepository.GetAll().ToList().Select(setor => setorDTO.MapToDTO(setor)).ToList();
            return PartialView("~/Views/Funcao/Create.cshtml");
        }

        [HttpPost]
        public IActionResult Create(FuncaoDTO funcaoDTO)
        {
            if (ModelState.IsValid)
            {
                _funcaoRepository.Save(funcaoDTO.MapToEntity(funcaoDTO));
                TempData["Success"] = "Salvo com sucesso";
                return RedirectToAction("Index", "Cadastros");
            }
            return RedirectToAction("Index", "Cadastros");
        }

    }
}

using CensoErgonomico.Domain.DTOs;
using CensoErgonomico.Domain.Interfaces.Repositories;
using CensoErgonomico.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace CensoErgonomico.WebApp.Controllers
{
    public class ColaboradorController : Controller
    {
        private readonly IColaboradorRepository _colaboradorRepository;
        private readonly IFuncaoRepository _funcaoRepository;
        private readonly ISetorRepository _setorRepository;
        private readonly IPessoaRepository _pessoaRepository;

        public ColaboradorController(IColaboradorRepository colaboradorRepository, 
            ISetorRepository setorRepository, IFuncaoRepository funcaoRepository, IPessoaRepository pessoaRepository)
        {
            _colaboradorRepository= colaboradorRepository;
            _setorRepository = setorRepository;
            _funcaoRepository = funcaoRepository;
            _pessoaRepository = pessoaRepository;
        }
        public IActionResult Index()
        {
            SetorDTO setorDTO = new SetorDTO();
            FuncaoDTO funcaoDTO = new FuncaoDTO();
            PessoaDTO pessoaDTO = new PessoaDTO();
            ViewBag.setores = _setorRepository.GetAll().ToList().Select(setor => setorDTO.MapToDTO(setor)).ToList();
            ViewBag.funcoes = _funcaoRepository.GetAll().ToList().Select(funcao => funcaoDTO.MapToDTO(funcao)).ToList();
            ViewBag.pessoas = _pessoaRepository.GetAll().ToList().Select(pessoa => pessoaDTO.MapToDTO(pessoa)).ToList();
            return PartialView("~/Views/Colaborador/Create.cshtml");
        }

        [HttpPost]
        public IActionResult Create(ColaboradorDTO colaboradorDTO)
        {
            if (ModelState.IsValid)
            {
                _colaboradorRepository.Save(colaboradorDTO.MapToEntity(colaboradorDTO));
                TempData["Success"] = "Salvo com sucesso";
                return RedirectToAction("Index", "Cadastros");
            }
            return RedirectToAction("Index", "Cadastros");
        }

        [HttpGet]
        public IActionResult GetFuncoes(Guid setorId)
        {
            var funcoes = _funcaoRepository.GetAll().Where(f => f.SetorId == setorId).ToList();

            List<FuncaoDTO> funcoesDTO = new List<FuncaoDTO>();
            FuncaoDTO funcaoDTO = new FuncaoDTO();
            funcoesDTO = funcoes.Select(f => funcaoDTO.MapToDTO(f)).ToList();

            return Json(funcoes);
        }
    }
}

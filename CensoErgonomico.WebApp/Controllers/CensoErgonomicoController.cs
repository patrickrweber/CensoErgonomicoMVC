using CensoErgonomico.Domain.DTOs;
using CensoErgonomico.Domain.Interfaces.Repositories;
using CensoErgonomico.Domain.Models;
using CensoErgonomico.Infra.Data.Data;
using CensoErgonomico.Infra.Data.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CensoErgonomico.WebApp.Controllers
{
    public class CensoErgonomicoController : Controller
    {
        private readonly ICensoErgonomicoRepository _censoRepository;
        private readonly IColaboradorRepository _colaboradorRepository;
        public CensoErgonomicoController(ICensoErgonomicoRepository censoRepository,
            IColaboradorRepository colaboradorRepository)
        {
            _censoRepository = censoRepository;
            _colaboradorRepository = colaboradorRepository;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create(CensoErgonomicoDTO censo)
        {
            return RedirectToAction("Cadastro", "CensoErgonomico");
        }
        public IActionResult Cadastro()
        {
            ColaboradorDTO colaboradorDTO = new ColaboradorDTO();
            ViewBag.colaboradores = _colaboradorRepository.GetAll()
                .Include(c => c.Pessoa).Select(colaborador => colaboradorDTO.MapToDTO(colaborador)).ToList();

            return View();
        }

        public IActionResult GetColaborador(Guid id) 
        {
            Colaborador colaborador =  _colaboradorRepository.GetAll()
                .Include(c => c.Pessoa)
                .Include(c => c.Setor)
                .Include(c => c.Funcao)
                .FirstOrDefault(c => c.Id.Equals(id));

            if(colaborador == null)
            {
                return NotFound();
            }

            ColaboradorDTO colaboradorDTO = new ColaboradorDTO();
            colaboradorDTO = colaboradorDTO.MapToDTO(colaborador);

            var colabJson = new
            {
                idade = DateTime.Today.Year - colaboradorDTO.pessoa.DataNascimento.Year,
                sexo = colaboradorDTO.pessoa.Sexo.ToString(),
                turno = colaboradorDTO.turno.ToString(),
                setor = colaboradorDTO.setor.Nome,
                funcao = colaboradorDTO.funcao.Nome,
                cadastro = colaboradorDTO.cadastro
            };

            return Ok(colabJson);
        }

        public IActionResult GetViewHabitos()
        {
            return PartialView("~/Views/CensoErgonomico/Habitos.cshtml");
        }
    }
}

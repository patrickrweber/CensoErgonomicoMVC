﻿using CensoErgonomico.Domain.DTOs;
using CensoErgonomico.Domain.Enums;
using CensoErgonomico.Domain.Interfaces.Repositories;
using CensoErgonomico.Domain.Models;
using CensoErgonomico.Infra.Data.Data;
using CensoErgonomico.Infra.Data.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection;

namespace CensoErgonomico.WebApp.Controllers
{
    public class CensoErgonomicoController : Controller
    {
        private readonly ICensoErgonomicoRepository _censoRepository;
        private readonly IColaboradorRepository _colaboradorRepository;
        private readonly IIMCRepository _imcRepository;
        public CensoErgonomicoController(ICensoErgonomicoRepository censoRepository,
            IColaboradorRepository colaboradorRepository, IIMCRepository imcRepository)
        {
            _censoRepository = censoRepository;
            _colaboradorRepository = colaboradorRepository;
            _imcRepository = imcRepository;
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
                idade = colaboradorDTO.pessoa.Idade,
                sexo = colaboradorDTO.pessoa.Sexo.ToString(),
                turno = colaboradorDTO.turno.ToString(),
                setor = colaboradorDTO.setor.Nome,
                funcao = colaboradorDTO.funcao.Nome,
                cadastro = colaboradorDTO.cadastro,
            };

            return Ok(colabJson);
        }
        public IActionResult GetIMC(Guid id)
        {
            Colaborador colaborador = _colaboradorRepository.GetAll()
               .Include(c => c.Pessoa)
               .FirstOrDefault(c => c.Id.Equals(id));

            ColaboradorDTO colaboradorDTO = new ColaboradorDTO();
            colaboradorDTO = colaboradorDTO.MapToDTO(colaborador);

            IMCDTO imcDTO = new IMCDTO();
            imcDTO = imcDTO.MapToDTO(_imcRepository.GetAll().First(imc => imc.PessoaId.Equals(colaboradorDTO.pessoaId)));

            if (colaborador == null || colaboradorDTO == null || imcDTO == null)
            {
                return NotFound();
            }

            var colabJson = new
            {
                altura = imcDTO.altura,
                peso = imcDTO.peso,
                imc = imcDTO.imc,
                classificacao = imcDTO.classificacaoIMC.ToString(),
            };

            return Ok(colabJson);
        }

        public IActionResult GetViewHabitos()
        {
            return PartialView("~/Views/CensoErgonomico/Habitos.cshtml");
        }
        public IActionResult GetViewLocaisDores()
        {
            ViewBag.locaisDores = GetAttributeDictionary<LocaisDoresDTO>();
            return PartialView("~/Views/CensoErgonomico/LocaisDores.cshtml");
        }   
        public static Dictionary<PropertyInfo, string> GetAttributeDictionary<T>()
        {
            Dictionary<PropertyInfo, string> attributeDictionary = new Dictionary<PropertyInfo, string>();

            foreach (PropertyInfo property in typeof(T).GetProperties())
            {
                LegendaAttribute atributoLegenda = property.GetCustomAttribute<LegendaAttribute>();

                if(atributoLegenda != null)
                {
                    attributeDictionary.Add(property, atributoLegenda.Legenda);
                }
            }

            return attributeDictionary;
        }
    }
}

﻿using CensoErgonomico.Domain.Enums;
using CensoErgonomico.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CensoErgonomico.Domain.DTOs
{
    public class SintomasDTO
    {
        public Guid id { get; set; }

        public bool dor { get; set; }
        public bool cansaco { get; set; }
        public bool estalos { get; set; }
        public bool choques { get; set; }
        public bool dolorimento { get; set; }
        public bool formigamento { get; set; }
        public bool reducaoForca { get; set; }
        public bool limitacaoMovimento { get; set; }
        public TipoTempoQueixa tempoQueixa { get; set; }

        public int censoErgonomicoId { get; set; }
        public virtual Models.CensoErgonomico? censoErgonomico { get; set; }

        public Sintomas MapToEntity(SintomasDTO sintomasDTO)
        {
            return new Sintomas
            {
                Id = sintomasDTO.id,
                Dor = sintomasDTO.dor,
                Cansaco = sintomasDTO.cansaco,
                Estalos = sintomasDTO.estalos,
                Choques = sintomasDTO.choques,
                Dolorimento = sintomasDTO.dolorimento,
                Formigamento = sintomasDTO.formigamento,
                ReducaoForca = sintomasDTO.reducaoForca,
                LimitacaoMovimento = sintomasDTO.limitacaoMovimento,
                TempoQueixa = sintomasDTO.tempoQueixa,
                CensoErgonomicoId = sintomasDTO.censoErgonomicoId,
                CensoErgonomico = sintomasDTO.censoErgonomico,
            };
        }
        public SintomasDTO MapToDTO(Sintomas sintomas)
        {
            return new SintomasDTO
            {
                id = sintomas.Id,
                dor = sintomas.Dor,
                cansaco = sintomas.Cansaco,
                estalos = sintomas.Estalos,
                choques = sintomas.Choques,
                dolorimento = sintomas.Dolorimento,
                formigamento = sintomas.Formigamento,
                reducaoForca = sintomas.ReducaoForca,
                limitacaoMovimento = sintomas.LimitacaoMovimento,
                tempoQueixa = sintomas.TempoQueixa,
                censoErgonomicoId = sintomas.CensoErgonomicoId,
                censoErgonomico = sintomas.CensoErgonomico
            };
        }
    }
}

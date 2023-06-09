﻿using CensoErgonomico.Domain.Models;

namespace CensoErgonomico.Domain.DTOs
{
    public class CensoErgonomicoDTO
    {
        public Guid id { get; set; }
        public DateTime dataCadastro { get; set; }

        public Guid colaboradorId { get; set; }
        public virtual Colaborador? colaborador { get; set; }

        public Guid imcId { get; set; }
        public virtual IMC? imc { get; set; }

        public bool fumante { get; set; }
        public bool praticaExercicio { get; set; }
        public bool senteDor { get; set; }

        public string consideracaoMotivoDor { get; set; }
        public string sugestaoMelhoria { get; set; }

        public Guid acoesId { get; set; }
        public virtual Acoes? acoes { get; set; }

        public Guid locaisDoresId { get; set; }
        public virtual LocaisDores? locaisDores { get; set; }

        public Guid sintomasId { get; set; }
        public virtual Sintomas? sintomas { get; set; }

        public Models.CensoErgonomico MapToEntity(CensoErgonomicoDTO censoErgonomicoDTO)
        {
            return new Models.CensoErgonomico
            {
                Id = censoErgonomicoDTO.id,
                DataCadastro = censoErgonomicoDTO.dataCadastro,
                ColaboradorId = censoErgonomicoDTO.colaboradorId,
                Colaborador = censoErgonomicoDTO.colaborador,
                IMCId = censoErgonomicoDTO.imcId,
                IMC = censoErgonomicoDTO.imc,
                Fumante = censoErgonomicoDTO.fumante,
                PraticaExercicio = censoErgonomicoDTO.praticaExercicio,
                SenteDor = censoErgonomicoDTO.senteDor,
                ConsideracaoMotivoDor = censoErgonomicoDTO.consideracaoMotivoDor,
                SugestaoMelhoria = censoErgonomicoDTO.sugestaoMelhoria,
                AcoesId = censoErgonomicoDTO.acoesId,
                Acoes = censoErgonomicoDTO.acoes,
                LocaisDoresId = censoErgonomicoDTO.locaisDoresId,
                LocaisDores = censoErgonomicoDTO.locaisDores,
                SintomasId = censoErgonomicoDTO.sintomasId,
                Sintomas = censoErgonomicoDTO.sintomas
            };
        }
        public CensoErgonomicoDTO MapToDTO(Models.CensoErgonomico censoErgonomico)
        {
            return new CensoErgonomicoDTO
            {
                id = censoErgonomico.Id,
                dataCadastro = censoErgonomico.DataCadastro,
                colaboradorId = censoErgonomico.ColaboradorId,
                colaborador = censoErgonomico.Colaborador,
                imcId = censoErgonomico.IMCId,
                imc = censoErgonomico.IMC,
                fumante = censoErgonomico.Fumante,
                praticaExercicio = censoErgonomico.PraticaExercicio,
                senteDor = censoErgonomico.SenteDor,
                consideracaoMotivoDor = censoErgonomico.ConsideracaoMotivoDor,
                sugestaoMelhoria = censoErgonomico.SugestaoMelhoria,
                acoesId = censoErgonomico.AcoesId,
                acoes = censoErgonomico.Acoes,
                locaisDoresId = censoErgonomico.LocaisDoresId,
                locaisDores = censoErgonomico.LocaisDores,
                sintomasId = censoErgonomico.SintomasId,
                sintomas = censoErgonomico.Sintomas
            };
        }
    }
}

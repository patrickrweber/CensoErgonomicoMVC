using CensoErgonomico.Domain.Enums;
using CensoErgonomico.Domain.Models;

namespace CensoErgonomico.Domain.DTOs
{
    public class AcoesDTO
    {
        public Guid id { get; set; }

        //Piora
        public bool piorHrExtra { get; set; }
        public bool piorJornadaNormal { get; set; }
        public bool piorFinalDia { get; set; }
        public bool piorAtivDomestica { get; set; }

        //Melhora
        public bool melhorNoite { get; set; }
        public bool melhorFimSemana { get; set; }
        public bool melhorRevezamento { get; set; }
        public bool melhorFerias { get; set; }

        //Medicamento
        public TipoMedicamento medicamento { get; set; }

        public Acoes MapToEntity(AcoesDTO acoesDTO)
        {
            return new Acoes
            {
                Id = acoesDTO.id,
                PiorHrExtra = acoesDTO.piorHrExtra,
                PiorJornadaNormal = acoesDTO.piorJornadaNormal,
                PiorFinalDia = acoesDTO.piorFinalDia,
                PiorAtivDomestica = acoesDTO.piorAtivDomestica,
                MelhorNoite = acoesDTO.melhorNoite,
                MelhorFimSemana = acoesDTO.melhorFimSemana,
                MelhorRevezamento = acoesDTO.melhorRevezamento,
                MelhorFerias = acoesDTO.melhorFerias,
                Medicamento = acoesDTO.medicamento
            };
        }
        public AcoesDTO MapToDTO(Acoes acoes)
        {
            return new AcoesDTO
            {
                id = acoes.Id,
                piorHrExtra = acoes.PiorHrExtra,
                piorJornadaNormal = acoes.PiorJornadaNormal,
                piorFinalDia = acoes.PiorFinalDia,
                piorAtivDomestica = acoes.PiorAtivDomestica,
                melhorNoite = acoes.MelhorNoite,
                melhorFimSemana = acoes.MelhorFimSemana,
                melhorRevezamento = acoes.MelhorRevezamento,
                melhorFerias = acoes.MelhorFerias,
                medicamento = acoes.Medicamento
            };
        }
    }   
}


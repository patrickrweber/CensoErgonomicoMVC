using CensoErgonomico.Domain.Enums;
using CensoErgonomico.Domain.Models;

namespace CensoErgonomico.Domain.DTOs
{
    public class IMCDTO
    {
        public Guid id { get; set; }

        public double altura { get; set; }
        public double peso { get; set; }
        public double imc
        {
            get
            {
                return peso / (altura * altura);
            }
        }
        public TipoClassificacaoIMC classificacaoIMC
        {
            get
            {
                if (imc < 18.25)
                    return TipoClassificacaoIMC.Desnutricao;
                if (imc < 24.9)
                    return TipoClassificacaoIMC.Eutrofia;
                if (imc < 29.9)
                    return TipoClassificacaoIMC.Sobrepeso;
                if (imc < 34.9)
                    return TipoClassificacaoIMC.ObesidadeI;
                if (imc < 39.9)
                    return TipoClassificacaoIMC.ObesidadeII;

                return TipoClassificacaoIMC.ObesidadeIII;
            }
        }
        public Guid pessoaId { get; set; }
        public virtual Pessoa? pessoa { get; set; }

        public IMC MapToEntity(IMCDTO imcDTO)
        {
            return new IMC
            {
                Id = imcDTO.id,
                Altura = imcDTO.altura,
                Peso = imcDTO.peso,
                PessoaId = imcDTO.pessoaId,
                Pessoa = imcDTO.pessoa,
            };
        }
        public IMCDTO MapToDTO(IMC imc)
        {
            return new IMCDTO
            {
                id = imc.Id,
                altura = imc.Altura,
                peso = imc.Peso,
                pessoaId = imc.PessoaId,
                pessoa = imc.Pessoa
            };
        }
    }
}

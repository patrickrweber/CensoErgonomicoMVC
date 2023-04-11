using CensoErgonomico.Domain.Enums;
using CensoErgonomico.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CensoErgonomico.Domain.DTOs
{
    public class IMCDTO
    {
        public Guid id { get; set; }

        public float altura { get; set; }
        public float peso { get; set; }
        public float imc
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
                switch (imc)
                {
                    case 0:
                        return TipoClassificacaoIMC.Desnutricao;
                    case 1:
                        return TipoClassificacaoIMC.Eutrofia;
                    case 2:
                        return TipoClassificacaoIMC.Sobrepeso;
                    case 3:
                        return TipoClassificacaoIMC.ObesidadeI;
                    case 4:
                        return TipoClassificacaoIMC.ObesidadeII;
                    case 5:
                        return TipoClassificacaoIMC.ObesidadeIII;
                    default:
                        return TipoClassificacaoIMC.NR;
                }

            }
        }
        public int pessoaId { get; set; }
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

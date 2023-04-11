using CensoErgonomico.Domain.Enums;
using CensoErgonomico.Domain.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CensoErgonomico.Domain.DTOs
{
    public class ColaboradorDTO
    {
        public Guid id { get; set; }
        public string cadastro { get; set; }
        public TipoTurno turno { get; set; }

        public int setorId { get; set; }
        public virtual Setor? setor { get; set; }

        public int funcaoId { get; set; }
        public virtual Funcao? funcao { get; set; }

        public int pessoaId { get; set; }
        public virtual Pessoa? pessoa { get; set; }

        public Colaborador MapToEntity(ColaboradorDTO colaboradorDTO)
        {
            return new Colaborador
            {
                Id = colaboradorDTO.id,
                Cadastro = colaboradorDTO.cadastro,
                Turno = colaboradorDTO.turno,
                SetorId = colaboradorDTO.setorId,
                Setor = colaboradorDTO.setor,
                FuncaoId = colaboradorDTO.funcaoId,
                Funcao = colaboradorDTO.funcao,
                PessoaId = colaboradorDTO.pessoaId,
                Pessoa = colaboradorDTO.pessoa
            };
        }
        public ColaboradorDTO MapToDTO(Colaborador colaborador)
        {
            return new ColaboradorDTO
            {
                id = colaborador.Id,
                cadastro = colaborador.Cadastro,
                turno = colaborador.Turno,
                setorId = colaborador.SetorId,
                setor = colaborador.Setor,
                funcaoId = colaborador.FuncaoId,
                funcao = colaborador.Funcao,
                pessoaId = colaborador.PessoaId,
                pessoa = colaborador.Pessoa
            };
        }
    }
}

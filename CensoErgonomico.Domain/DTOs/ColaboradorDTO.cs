using CensoErgonomico.Domain.Enums;
using CensoErgonomico.Domain.Models;

namespace CensoErgonomico.Domain.DTOs
{
    public class ColaboradorDTO
    {
        public Guid id { get; set; }
        public string cadastro { get; set; }
        public TipoTurno turno { get; set; }
        public DateTime inicioFuncao { get; set; }

        public Guid setorId { get; set; }
        public virtual Setor? setor { get; set; }

        public Guid funcaoId { get; set; }
        public virtual Funcao? funcao { get; set; }

        public Guid pessoaId { get; set; }
        public virtual Pessoa? pessoa { get; set; }

        public virtual ICollection<Models.CensoErgonomico>? censoErgonomicos { get; set; }

        public Colaborador MapToEntity(ColaboradorDTO colaboradorDTO)
        {
            return new Colaborador
            {
                Id = colaboradorDTO.id,
                Cadastro = colaboradorDTO.cadastro,
                Turno = colaboradorDTO.turno,
                InicioFuncao = inicioFuncao,
                SetorId = colaboradorDTO.setorId,
                Setor = colaboradorDTO.setor,
                FuncaoId = colaboradorDTO.funcaoId,
                Funcao = colaboradorDTO.funcao,
                PessoaId = colaboradorDTO.pessoaId,
                Pessoa = colaboradorDTO.pessoa,
                CensoErgonomicos = censoErgonomicos
            };
        }
        public ColaboradorDTO MapToDTO(Colaborador colaborador)
        {
            return new ColaboradorDTO
            {
                id = colaborador.Id,
                cadastro = colaborador.Cadastro,
                turno = colaborador.Turno,
                inicioFuncao = inicioFuncao,
                setorId = colaborador.SetorId,
                setor = colaborador.Setor,
                funcaoId = colaborador.FuncaoId,
                funcao = colaborador.Funcao,
                pessoaId = colaborador.PessoaId,
                pessoa = colaborador.Pessoa,
                censoErgonomicos = censoErgonomicos
            };
        }
    }
}

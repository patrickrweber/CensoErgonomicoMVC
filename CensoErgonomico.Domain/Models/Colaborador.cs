using CensoErgonomico.Domain.Enums;
using System.ComponentModel.DataAnnotations;

namespace CensoErgonomico.Domain.Models
{
    public class Colaborador
    {
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Digite o cadastro do colaborador")]
        public string Cadastro{ get; set; }

        [Required(ErrorMessage = "Digite o turno do colaborador")]
        public TipoTurno Turno { get; set; }
        public DateTime InicioFuncao { get; set; }

        public Guid SetorId { get; set; }
        public virtual Setor? Setor { get; set; }

        public Guid FuncaoId { get; set; }
        public virtual Funcao? Funcao { get; set; }

        public Guid PessoaId { get; set; }
        public virtual Pessoa? Pessoa { get;set; } 

        public virtual ICollection<CensoErgonomico>? CensoErgonomicos { get; set; }
    }
}

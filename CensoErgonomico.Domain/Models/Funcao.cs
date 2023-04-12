using System.ComponentModel.DataAnnotations;

namespace CensoErgonomico.Domain.Models
{
    public class Funcao
    {
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Digite o nome da pessoa")]
        public string Nome { get; set; }

        public int SetorId { get; set; }
        public Setor? Setor { get; set; }

        public virtual ICollection<Colaborador>? Colaboradores { get;set; }
    }
}

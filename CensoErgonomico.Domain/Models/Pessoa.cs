using CensoErgonomico.Domain.Enums;
using System.ComponentModel.DataAnnotations;

namespace CensoErgonomico.Domain.Models
{
    public class Pessoa
    {
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Digite o nome da pessoa")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Digite o CPF da pessoa")]
        public string CPF { get; set; }

        [Required(ErrorMessage = "Digite a data de nascimento da pessoa")]
        public DateTime DataNascimento  { get; set; }

        [Required(ErrorMessage = "Digite o sexo da pessoa")]
        public TipoSexo Sexo  { get; set; }
        public int Idade
        {
            get
            {
                return DateTime.Today.Year - DataNascimento.Year;
            }
        }

        public virtual ICollection<Colaborador>?  Colaboradores { get; set;}
    }
}

using CensoErgonomico.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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


        public virtual List<Colaborador>?  Colaboradores { get; set;}
    }
}

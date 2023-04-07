using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CensoErgonomico.Domain.Models
{
    public class Setor
    {
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Digite o nome da pessoa")]
        public string Nome { get; set; }

        public virtual List<Colaborador>? Colaboradores { get; set; }
        public virtual List<Funcao>? Funcoes { get; set; }
    }
}

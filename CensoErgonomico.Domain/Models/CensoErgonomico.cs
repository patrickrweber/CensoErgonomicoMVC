using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CensoErgonomico.Domain.Models
{
    public class CensoErgonomico
    {
        public Guid Id { get; set; }
        public DateTime DataCadastro { get; set; }

        public int ColaboradorId { get; set; }
        public virtual Colaborador? Colaborador { get; set; }

        public bool Fumante { get; set; }
        public bool PraticaExercicio { get; set; }
        public bool SenteDor { get; set; }

        public string ConsideracaoMotivoDor { get; set; }
        public string SugestaoMelhoria { get; set; }
    }
}

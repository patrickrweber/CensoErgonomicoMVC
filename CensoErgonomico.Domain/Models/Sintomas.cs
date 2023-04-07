using CensoErgonomico.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CensoErgonomico.Domain.Models
{
    public class Sintomas
    {
        public Guid Id { get; set; }

        public bool Dor { get; set; }
        public bool Cansaco { get; set; }
        public bool Estalos { get; set; }
        public bool Choques { get; set; }
        public bool Dolorimento { get; set; }
        public bool Formigamento { get; set; }
        public bool ReducaoForca { get; set; }
        public bool LimitacaoMovimento { get; set; }
        public TipoTempoQueixa TempoQueixa { get; set; }

        public int CensoErgonomicoId { get; set; }
        public virtual CensoErgonomico? CensoErgonomico { get; set; }
    }
}

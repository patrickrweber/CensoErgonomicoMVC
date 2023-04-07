using CensoErgonomico.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CensoErgonomico.Domain.Models
{
    public class LocaisDores
    {
        public Guid Id { get; set; }
        public TipoDor Pescoço { get; set; }
        public TipoDor CostasSuperior { get; set; }
        public TipoDor CostasInferior { get; set; }
        public TipoDor Ombro { get; set; }
        public TipoDor Braço { get; set; }
        public TipoDor Cotovelo { get; set; }
        public TipoDor Antebraço { get; set; }
        public TipoDor Punho { get; set; }
        public TipoDor Mão { get; set; }
        public TipoDor Quadril { get; set; }
        public TipoDor Coxa { get; set; }
        public TipoDor Joelho { get; set; }
        public TipoDor Perna { get; set; }
        public TipoDor Tornozelo { get; set; }
        public TipoDor Pe { get; set; }

        public int CensoErgonomicoId { get; set; }
        public virtual CensoErgonomico? CensoErgonomico { get; set; }
    }
}

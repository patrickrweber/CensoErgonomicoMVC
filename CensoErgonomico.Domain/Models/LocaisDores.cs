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
        public TipoDor PescoçoE { get; set; }
        public TipoDor PescoçoD { get; set; }
        public TipoDor CostasSuperiorE { get; set; }
        public TipoDor CostasSuperiorD { get; set; }
        public TipoDor CostasInferiorE { get; set; }
        public TipoDor CostasInferiorD { get; set; }
        public TipoDor OmbroE { get; set; }
        public TipoDor OmbroD { get; set; }
        public TipoDor BraçoE { get; set; }
        public TipoDor BraçoD { get; set; }
        public TipoDor CotoveloE { get; set; }
        public TipoDor CotoveloD { get; set; }
        public TipoDor AntebracoE { get; set; }
        public TipoDor AntebracoD { get; set; }
        public TipoDor PunhoE { get; set; }
        public TipoDor PunhoD { get; set; }
        public TipoDor MaoE { get; set; }
        public TipoDor MaoD { get; set; }
        public TipoDor QuadrilE { get; set; }
        public TipoDor QuadrilD { get; set; }
        public TipoDor CoxaE { get; set; }
        public TipoDor CoxaD { get; set; }
        public TipoDor JoelhoE { get; set; }
        public TipoDor JoelhoD { get; set; }
        public TipoDor PernaE { get; set; }
        public TipoDor PernaD { get; set; }
        public TipoDor TornozeloE { get; set; }
        public TipoDor TornozeloD { get; set; }
        public TipoDor PeE { get; set; }
        public TipoDor PeD { get; set; }

        public int CensoErgonomicoId { get; set; }
        public virtual CensoErgonomico? CensoErgonomico { get; set; }
    }
}

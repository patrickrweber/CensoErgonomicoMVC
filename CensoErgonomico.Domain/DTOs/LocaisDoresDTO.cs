using CensoErgonomico.Domain.Enums;
using CensoErgonomico.Domain.Models;

namespace CensoErgonomico.Domain.DTOs
{
    public class LocaisDoresDTO
    {
        public Guid id { get; set; }
        public TipoDor pescoçoE { get; set; }
        public TipoDor pescoçoD { get; set; }
        public TipoDor costasSuperiorE { get; set; }
        public TipoDor costasSuperiorD { get; set; }
        public TipoDor costasInferiorE { get; set; }
        public TipoDor costasInferiorD { get; set; }
        public TipoDor ombroE { get; set; }
        public TipoDor ombroD { get; set; }
        public TipoDor braçoE { get; set; }
        public TipoDor braçoD { get; set; }
        public TipoDor cotoveloE { get; set; }
        public TipoDor cotoveloD { get; set; }
        public TipoDor antebracoE { get; set; }
        public TipoDor antebracoD { get; set; }
        public TipoDor punhoE { get; set; }
        public TipoDor punhoD { get; set; }
        public TipoDor maoE { get; set; }
        public TipoDor maoD { get; set; }
        public TipoDor quadrilE { get; set; }
        public TipoDor quadrilD { get; set; }
        public TipoDor coxaE { get; set; }
        public TipoDor coxaD { get; set; }
        public TipoDor joelhoE { get; set; }
        public TipoDor joelhoD { get; set; }
        public TipoDor pernaE { get; set; }
        public TipoDor pernaD { get; set; }
        public TipoDor tornozeloE { get; set; }
        public TipoDor tornozeloD { get; set; }
        public TipoDor peE { get; set; }
        public TipoDor peD { get; set; }

        public LocaisDores MapToEntity(LocaisDoresDTO locaisDoresDTO)
        {
            return new LocaisDores
            {
                Id = locaisDoresDTO.id,
                PescoçoE = locaisDoresDTO.pescoçoE,
                PescoçoD = locaisDoresDTO.pescoçoD,
                CostasSuperiorE = locaisDoresDTO.costasSuperiorE,
                CostasSuperiorD = locaisDoresDTO.costasSuperiorD,
                CostasInferiorE = locaisDoresDTO.costasInferiorE,
                CostasInferiorD = locaisDoresDTO.costasInferiorD,
                OmbroE = locaisDoresDTO.ombroE,
                OmbroD = locaisDoresDTO.ombroD,
                BraçoE = locaisDoresDTO.braçoE,
                BraçoD = locaisDoresDTO.braçoD,
                CotoveloE = locaisDoresDTO.cotoveloE,
                CotoveloD = locaisDoresDTO.cotoveloD,
                AntebracoE = locaisDoresDTO.antebracoE,
                AntebracoD = locaisDoresDTO.antebracoD,
                PunhoE = locaisDoresDTO.punhoE,
                PunhoD = locaisDoresDTO.punhoD,
                MaoE = locaisDoresDTO.maoE,
                MaoD = locaisDoresDTO.maoD,
                QuadrilE = locaisDoresDTO.quadrilE,
                QuadrilD = locaisDoresDTO.quadrilD,
                CoxaE = locaisDoresDTO.coxaE,
                CoxaD = locaisDoresDTO.coxaD,
                JoelhoE = locaisDoresDTO.joelhoE,
                JoelhoD = locaisDoresDTO.joelhoD,
                PernaE = locaisDoresDTO.pernaE,
                PernaD = locaisDoresDTO.pernaD,
                TornozeloE = locaisDoresDTO.tornozeloE,
                TornozeloD = locaisDoresDTO.tornozeloD,
                PeE = locaisDoresDTO.peE,
                PeD = locaisDoresDTO.peD,
            };
        }
        public LocaisDoresDTO MapToDTO(LocaisDores locaisDores)
        {
            return new LocaisDoresDTO
            {
                id = locaisDores.Id,
                pescoçoE = locaisDores.PescoçoE,
                pescoçoD = locaisDores.PescoçoD,
                costasSuperiorE = locaisDores.CostasSuperiorE,
                costasSuperiorD = locaisDores.CostasSuperiorD,
                costasInferiorE = locaisDores.CostasInferiorE,
                costasInferiorD = locaisDores.CostasInferiorD,
                ombroE = locaisDores.OmbroE,
                ombroD = locaisDores.OmbroD,
                braçoE = locaisDores.BraçoE,
                braçoD = locaisDores.BraçoD,
                cotoveloE = locaisDores.CotoveloE,
                cotoveloD = locaisDores.CotoveloD,
                antebracoE = locaisDores.AntebracoE,
                antebracoD = locaisDores.AntebracoD,
                punhoE = locaisDores.PunhoE,
                punhoD = locaisDores.PunhoD,
                maoE = locaisDores.MaoE,
                maoD = locaisDores.MaoD,
                quadrilE = locaisDores.QuadrilE,
                quadrilD = locaisDores.QuadrilD,
                coxaE = locaisDores.CoxaE,
                coxaD = locaisDores.CoxaD,
                joelhoE = locaisDores.JoelhoE,
                joelhoD = locaisDores.JoelhoD,
                pernaE = locaisDores.PernaE,
                pernaD = locaisDores.PernaD,
                tornozeloE = locaisDores.TornozeloE,
                tornozeloD = locaisDores.TornozeloD,
                peE = locaisDores.PeE,
                peD = locaisDores.PeD,
            };
        }
    }
}

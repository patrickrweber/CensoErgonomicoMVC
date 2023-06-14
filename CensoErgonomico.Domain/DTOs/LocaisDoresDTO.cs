using CensoErgonomico.Domain.Enums;
using CensoErgonomico.Domain.Models;
using System.Reflection;

namespace CensoErgonomico.Domain.DTOs
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    public class LegendaAttribute : Attribute
    {
        public string Legenda { get; }

        public LegendaAttribute(string legenda)
        {
            Legenda = legenda;
        }
    }
    public class LocaisDoresDTO
    {
        public Guid id { get; set; }

        [Legenda("Pescoço esquerdo")]
        public TipoDor pescoçoE { get; set; }
        [Legenda("Pescoço direito")]
        public TipoDor pescoçoD { get; set; }
        [Legenda("Costas superior esquerdo")]
        public TipoDor costasSuperiorE { get; set; }
        [Legenda("Costas superior direito")]
        public TipoDor costasSuperiorD { get; set; }
        [Legenda("Costas inferior esquerdo")]
        public TipoDor costasInferiorE { get; set; }
        [Legenda("Costas inferior direito")]
        public TipoDor costasInferiorD { get; set; }
        [Legenda("Ombro esquerdo")]
        public TipoDor ombroE { get; set; }
        [Legenda("Ombro direito")]
        public TipoDor ombroD { get; set; }
        [Legenda("Braço esquerdo")]
        public TipoDor braçoE { get; set; }
        [Legenda("Braço direito")]
        public TipoDor braçoD { get; set; }
        [Legenda("Cotovelo esquerdo")]
        public TipoDor cotoveloE { get; set; }
        [Legenda("Cotovelo direito")]
        public TipoDor cotoveloD { get; set; }
        [Legenda("Antebraço esquerdo")]
        public TipoDor antebracoE { get; set; }
        [Legenda("Antebraço direito")]
        public TipoDor antebracoD { get; set; }
        [Legenda("Punho esquerdo")]
        public TipoDor punhoE { get; set; }
        [Legenda("Punho direito")]
        public TipoDor punhoD { get; set; }
        [Legenda("Mão esquerda")]
        public TipoDor maoE { get; set; }
        [Legenda("Mão direita")]
        public TipoDor maoD { get; set; }
        [Legenda("Quadril esquerdo")]
        public TipoDor quadrilE { get; set; }
        [Legenda("Quadril direito")]
        public TipoDor quadrilD { get; set; }
        [Legenda("Coxa esquerda")]
        public TipoDor coxaE { get; set; }
        [Legenda("Coxa direita")]
        public TipoDor coxaD { get; set; }
        [Legenda("Joelho esquerdo")]
        public TipoDor joelhoE { get; set; }
        [Legenda("Joelho direito")]
        public TipoDor joelhoD { get; set; }
        [Legenda("Perna esquerda")]
        public TipoDor pernaE { get; set; }
        [Legenda("Perna direita")]
        public TipoDor pernaD { get; set; }
        [Legenda("Tornozelo esquerdo")]
        public TipoDor tornozeloE { get; set; }
        [Legenda("Tornozelo direito")]
        public TipoDor tornozeloD { get; set; }
        [Legenda("Pé esquerdo")]
        public TipoDor peE { get; set; }
        [Legenda("Pé direito")]
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

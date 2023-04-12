namespace CensoErgonomico.Domain.Models
{
    public class CensoErgonomico
    {
        public Guid Id { get; set; }
        public DateTime DataCadastro { get; set; }

        public Guid ColaboradorId { get; set; }
        public virtual Colaborador? Colaborador { get; set; }

        public Guid IMCId { get; set; }
        public virtual IMC? IMC { get; set; }

        public bool Fumante { get; set; }
        public bool PraticaExercicio { get; set; }
        public bool SenteDor { get; set; }

        public string ConsideracaoMotivoDor { get; set; }
        public string SugestaoMelhoria { get; set; }

        public Guid AcoesId { get; set; }
        public virtual Acoes? Acoes { get; set; }

        public Guid LocaisDoresId { get; set; }
        public virtual LocaisDores? LocaisDores { get; set; }

        public Guid SintomasId { get; set; }
        public virtual Sintomas? Sintomas { get; set; }
    }
}

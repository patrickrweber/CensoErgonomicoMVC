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

        public int AcoesId { get; set; }
        public virtual Acoes? Acoes { get; set; }

        public int LocaisDoresId { get; set; }
        public virtual LocaisDores? LocaisDores { get; set; }

        public int SintomasId { get; set; }
        public virtual Sintomas? Sintomas { get; set; }
    }
}

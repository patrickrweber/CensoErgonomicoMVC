using CensoErgonomico.Domain.Enums;

namespace CensoErgonomico.Domain.Models
{
    public class IMC
    {
        public Guid Id { get; set; }

        public double Altura { get; set; }
        public double Peso { get; set; }
        public double Imc
        {
            get
            {
                return Peso / (Altura * Altura);
            }
        }
        public TipoClassificacaoIMC ClassificacaoIMC
        {
            get
            {
                switch (Imc)
                {
                    case 0:
                        return TipoClassificacaoIMC.Desnutricao;
                    case 1:
                        return TipoClassificacaoIMC.Eutrofia;
                    case 2:
                        return TipoClassificacaoIMC.Sobrepeso;
                    case 3:
                        return TipoClassificacaoIMC.ObesidadeI;
                    case 4:
                        return TipoClassificacaoIMC.ObesidadeII;
                    case 5:
                        return TipoClassificacaoIMC.ObesidadeIII;
                    default:
                        return TipoClassificacaoIMC.NR;
                }

            }
        }
        public Guid PessoaId { get; set; }
        public virtual Pessoa? Pessoa { get; set; }
    }
}

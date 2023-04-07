using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CensoErgonomico.Domain.Enums
{
    public enum TipoClassificacaoIMC
    {
        [Description("Desnutrição")]
        Desnutricao = 0,
        [Description("Eutrofia")]
        Eutrofia = 1,
        [Description("Sobrepeso")]
        Sobrepeso = 2,
        [Description("Obesidade I")]
        ObesidadeI = 3,
        [Description("Obesidade II")]
        ObesidadeII = 4,
        [Description("Obesidade III")]
        ObesidadeIII = 5,
        [Description("NR")]
        NR = 6,
    }
}

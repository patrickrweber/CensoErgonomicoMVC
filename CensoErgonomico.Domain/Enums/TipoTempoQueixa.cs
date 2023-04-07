using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CensoErgonomico.Domain.Enums
{
    public enum TipoTempoQueixa
    {
        [Description("Menos de um mês")]
        MenosUmMes = 0,
        [Description("1 a 3 meses")]
        UmTresMeses = 1,
        [Description("3 a 6 meses")]
        TresSeisMeses = 2,
        [Description("Acima de 6 meses")]
        MaisSeisMeses = 3,
        [Description("Acima de um ano")]
        MaisUmAno = 4
    }
}

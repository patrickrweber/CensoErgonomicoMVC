using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CensoErgonomico.Domain.Enums
{
    public enum TipoMedicamento
    {
        [Description("Sim")]
        Sim = 0,
        [Description("Não")]
        Nao = 1,
        [Description("Às vezes")]
        AsVezes = 3
    }
}

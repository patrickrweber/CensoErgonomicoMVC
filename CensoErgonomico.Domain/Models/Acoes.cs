﻿using CensoErgonomico.Domain.Enums;

namespace CensoErgonomico.Domain.Models
{
    public class Acoes
    {
        public Guid Id { get; set; }

        //Piora
        public bool PiorHrExtra { get; set; }
        public bool PiorJornadaNormal { get; set; }
        public bool PiorFinalDia { get; set; }
        public bool PiorAtivDomestica { get; set; }

        //Melhora
        public bool MelhorNoite { get; set; }
        public bool MelhorFimSemana { get; set; }
        public bool MelhorRevezamento { get; set; }
        public bool MelhorFerias { get; set; }

        //Medicamento
        public TipoMedicamento Medicamento { get; set; }
    }
}

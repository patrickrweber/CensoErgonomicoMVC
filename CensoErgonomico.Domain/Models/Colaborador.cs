﻿using CensoErgonomico.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CensoErgonomico.Domain.Models
{
    public class Colaborador
    {
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Digite o cadastro do colaborador")]
        public string Cadastro{ get; set; }

        [Required(ErrorMessage = "Digite o turno do colaborador")]
        public TipoTurno Turno { get; set; }

        public int SetorId { get; set; }
        public virtual Setor? Setor { get; set; }

        public int FuncaoId { get; set; }
        public virtual Funcao? Funcao { get; set; }

        public int PessoaId { get; set; }
        public virtual Pessoa? Pessoa { get;set; } 
    }
}
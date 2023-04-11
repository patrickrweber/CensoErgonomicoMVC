using CensoErgonomico.Domain.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CensoErgonomico.Domain.DTOs
{
    public class SetorDTO
    {
        public Guid id { get; set; }
        public string nome { get; set; }
        public virtual List<Colaborador>? colaboradores { get; set; }
        public virtual List<Funcao>? funcoes { get; set; }

        public Setor MapToEntity(SetorDTO setorDTO)
        {
            return new Setor
            {
                Id = setorDTO.id,
                Nome = setorDTO.nome,
                Colaboradores = setorDTO.colaboradores,
                Funcoes = setorDTO.funcoes
            };
        }
        public SetorDTO MapToDTO(Setor setor)
        {
            return new SetorDTO
            {
                id = setor.Id,
                nome = setor.Nome,
                colaboradores = setor.Colaboradores,
                funcoes = setor.Funcoes
            };
        }
    }
}

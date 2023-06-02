using CensoErgonomico.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CensoErgonomico.Domain.DTOs
{
    public class PessoaLinks
    {
        public PessoaDTO Pessoa { get; set; }
        public IMCDTO IMC { get; set; }

        public Pessoa MapToPessoaEntity(PessoaLinks pessoaIMC)
        {
            return new Pessoa() 
            {
                Nome = pessoaIMC.Pessoa.nome,
                CPF = pessoaIMC.Pessoa.cpf,
                DataNascimento = pessoaIMC.Pessoa.dataNascimento,
                Sexo = pessoaIMC.Pessoa.sexo
            };

        }

        public IMC MapToIMCEntity(PessoaLinks pessoaIMC, Guid idPessoa)
        {
            return new IMC()
            {
                Altura = pessoaIMC.IMC.altura,
                Peso = pessoaIMC.IMC.peso,
                PessoaId = idPessoa
            };
        }
    }
}

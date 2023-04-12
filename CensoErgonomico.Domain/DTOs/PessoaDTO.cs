using CensoErgonomico.Domain.Enums;
using CensoErgonomico.Domain.Models;

namespace CensoErgonomico.Domain.DTOs
{
    public class PessoaDTO
    {
        public Guid id { get; set; }
        public string nome { get; set; }
        public string cpf { get; set; }
        public DateTime dataNascimento { get; set; }
        public TipoSexo sexo { get; set; }
        public virtual ICollection<Colaborador>? colaboradores { get; set; }

        public Pessoa MapToEntity(PessoaDTO pessoaDTO)
        {
            return new Pessoa
            {
                Id = pessoaDTO.id,
                Nome = pessoaDTO.nome,
                CPF = pessoaDTO.cpf,
                DataNascimento = pessoaDTO.dataNascimento,
                Sexo = pessoaDTO.sexo,
                Colaboradores = pessoaDTO.colaboradores,
            };
        }
        public PessoaDTO MapToDTO(Pessoa pessoa)
        {
            return new PessoaDTO
            {
                id = pessoa.Id,
                nome = pessoa.Nome,
                cpf = pessoa.CPF,
                dataNascimento = pessoa.DataNascimento,
                sexo = pessoa.Sexo,
                colaboradores = pessoa.Colaboradores
            };
        }
    }
}

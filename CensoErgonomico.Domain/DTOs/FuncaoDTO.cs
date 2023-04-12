using CensoErgonomico.Domain.Models;

namespace CensoErgonomico.Domain.DTOs
{
    public class FuncaoDTO
    {
        public Guid id { get; set; }

        public string nome { get; set; }

        public Guid setorId { get; set; }
        public Setor? setor { get; set; }

        public virtual ICollection<Colaborador>? colaboradores { get; set; }

        public Funcao MapToEntity(FuncaoDTO funcaoDTO)
        {
            return new Funcao
            {
                Id = funcaoDTO.id,
                Nome = funcaoDTO.nome,
                SetorId = funcaoDTO.setorId,
                Setor = funcaoDTO.setor,
                Colaboradores = funcaoDTO.colaboradores,
            };
        }
        public FuncaoDTO MapToDTO(Funcao funcao)
        {
            return new FuncaoDTO
            {
                id = funcao.Id,
                nome = funcao.Nome,
                setorId = funcao.SetorId,
                setor = funcao.Setor,
                colaboradores = funcao.Colaboradores
            };
        }
    }
}

using CensoErgonomico.Domain.Interfaces.Repositories;
using CensoErgonomico.Domain.Models;
using CensoErgonomico.Infra.Data.Data;
namespace CensoErgonomico.Infra.Data.Repositories
{
    public class PessoaRepository : BaseRepository<Pessoa>, IPessoaRepository
    {
        private readonly MySqlContext? _dataContext;
        public PessoaRepository(MySqlContext context) : base(context)
        {
            _dataContext = context;
        }
    }
}

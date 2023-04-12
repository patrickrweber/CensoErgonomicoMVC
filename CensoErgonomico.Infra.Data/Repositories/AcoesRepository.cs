using CensoErgonomico.Domain.Interfaces.Repositories;
using CensoErgonomico.Domain.Models;
using CensoErgonomico.Infra.Data.Data;

namespace CensoErgonomico.Infra.Data.Repositories
{
    public class AcoesRepository : BaseRepository<Acoes>, IAcoesRepository
    {
        private readonly MySqlContext? _dataContext;
        public AcoesRepository(MySqlContext context) : base(context)
        {
            _dataContext = context;
        }
    }
}

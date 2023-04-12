using CensoErgonomico.Domain.Interfaces.Repositories;
using CensoErgonomico.Infra.Data.Data;
namespace CensoErgonomico.Infra.Data.Repositories
{
    public class CensoErgonomicoRepository : BaseRepository<Domain.Models.CensoErgonomico>, ICensoErgonomicoRepository
    {
        private readonly MySqlContext? _dataContext;
        public CensoErgonomicoRepository(MySqlContext context) : base(context)
        {
            _dataContext = context;
        }
    }
}

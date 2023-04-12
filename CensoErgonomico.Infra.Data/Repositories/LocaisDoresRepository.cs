using CensoErgonomico.Domain.Interfaces.Repositories;
using CensoErgonomico.Domain.Models;
using CensoErgonomico.Infra.Data.Data;
namespace CensoErgonomico.Infra.Data.Repositories
{
    public class LocaisDoresRepository : BaseRepository<LocaisDores>, ILocaisDoresRepository
    {
        private readonly MySqlContext? _dataContext;
        public LocaisDoresRepository(MySqlContext context) : base(context)
        {
            _dataContext = context;
        }
    }
}

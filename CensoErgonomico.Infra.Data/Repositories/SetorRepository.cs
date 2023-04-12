using CensoErgonomico.Domain.Interfaces.Repositories;
using CensoErgonomico.Domain.Models;
using CensoErgonomico.Infra.Data.Data;
namespace CensoErgonomico.Infra.Data.Repositories
{
    public class SetorRepository : BaseRepository<Setor>, ISetorRepository
    {
        private readonly MySqlContext? _dataContext;
        public SetorRepository(MySqlContext context) : base(context)
        {
            _dataContext = context;
        }
    }
}

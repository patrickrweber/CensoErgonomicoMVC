using CensoErgonomico.Domain.Interfaces.Repositories;
using CensoErgonomico.Domain.Models;
using CensoErgonomico.Infra.Data.Data;
namespace CensoErgonomico.Infra.Data.Repositories
{
    public class IMCRepository : BaseRepository<IMC>, IIMCRepository
    {
        private readonly MySqlContext? _dataContext;
        public IMCRepository(MySqlContext context) : base(context)
        {
            _dataContext = context;
        }
    }
}

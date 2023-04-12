using CensoErgonomico.Domain.Interfaces.Repositories;
using CensoErgonomico.Domain.Models;
using CensoErgonomico.Infra.Data.Data;
namespace CensoErgonomico.Infra.Data.Repositories
{
    public class FuncaoRepository : BaseRepository<Funcao>, IFuncaoRepository
    {
        private readonly MySqlContext? _dataContext;
        public FuncaoRepository(MySqlContext context) : base(context)
        {
            _dataContext = context;
        }
    }
}

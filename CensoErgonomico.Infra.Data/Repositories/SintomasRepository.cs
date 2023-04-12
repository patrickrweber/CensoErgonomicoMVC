using CensoErgonomico.Domain.Interfaces.Repositories;
using CensoErgonomico.Domain.Models;
using CensoErgonomico.Infra.Data.Data;

namespace CensoErgonomico.Infra.Data.Repositories
{
    public class SintomasRepository : BaseRepository<Sintomas>, ISintomasRepository
    {
        private readonly MySqlContext? _dataContext;
        public SintomasRepository(MySqlContext context) : base(context)
        {
            _dataContext = context;
        }
    }
}

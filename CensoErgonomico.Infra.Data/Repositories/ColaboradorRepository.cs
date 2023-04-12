using CensoErgonomico.Domain.Interfaces.Repositories;
using CensoErgonomico.Domain.Models;
using CensoErgonomico.Infra.Data.Data;

namespace CensoErgonomico.Infra.Data.Repositories
{
    public class ColaboradorRepository : BaseRepository<Colaborador>, IColaboradorRepository
    {
        private readonly MySqlContext? _dataContext;
        public ColaboradorRepository(MySqlContext context) : base(context)
        {
            _dataContext = context;
        }
    }
}

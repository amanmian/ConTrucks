using Contrucks.model;
using Contrucks.Repository.Infrastructure;
using System.Collections.Generic;

namespace Contrucks.Repository.Repository
{
    public class TruckTypeRepository : RepositoryBase<TruckTypes>, ITruckTypeRepository
    {
        public TruckTypeRepository(IDatabaseFactory databaseFactory) : base(databaseFactory)
        {

        }
    }

    public interface ITruckTypeRepository : IRepositoryBase<TruckTypes>
    {
        IEnumerable<TruckTypes> GetTruckType();
        
    }
}

using Contrucks.model;
using Contrucks.Repository.Infrastructure;
using System.Collections.Generic;

namespace Contrucks.Repository.Repository
{
    public class ContractorRepository : RepositoryBase<Contractors>, IContractorRepository
    {
        public ContractorRepository(IDatabaseFactory databaseFactory) : base(databaseFactory)
        {
        }

    }
    public interface IContractorRepository : IRepositoryBase<Contractors>
    {
        IEnumerable<Contractors> GetAll();
        void Add(Contractors contractors);
    }
}

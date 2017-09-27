using Contrucks.model;
using Contrucks.Repository.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contrucks.Repository.Repository
{
   public class LoadTypeRepository : RepositoryBase<LoadTypes>,ILoadTypesRepository
    {
        public LoadTypeRepository(IDatabaseFactory databaseFactory) : base(databaseFactory)
        {

        }  
    }

    public interface ILoadTypesRepository : IRepositoryBase<LoadTypes>
    {
        IEnumerable<LoadTypes> GetLoadType();
    }
}

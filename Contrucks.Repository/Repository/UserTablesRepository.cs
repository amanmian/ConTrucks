using Contrucks.model;
using Contrucks.Repository.Infrastructure;
using System.Collections.Generic;

namespace Contrucks.Repository.Repository
{
    public class UserTablesRepository : RepositoryBase<UserTables>, IUserTablesRepository
    {
        public UserTablesRepository(IDatabaseFactory databaseFactory) : base(databaseFactory)
        {
        }
    }
    public interface IUserTablesRepository : IRepositoryBase<UserTables>
    {
        IEnumerable<UserTables> GetAll();
        void Add(UserTables usertables);
    }

}

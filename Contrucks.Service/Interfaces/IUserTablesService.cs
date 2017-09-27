using Contrucks.model;
using Contrucks.model.ViewModels;
using System.Collections.Generic;

namespace Contrucks.Service
{
    public interface IUserTablesService
    {
        IEnumerable<UserTables> GetAllCustomers();
        void AddUser(ContractorRegistrationViewModel usertables);
    }
}
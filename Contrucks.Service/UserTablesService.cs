using Contrucks.model;
using Contrucks.model.ViewModels;
using Contrucks.Repository.Infrastructure;
using Contrucks.Repository.Repository;
using System;
using System.Collections.Generic;
///New One
namespace Contrucks.Service
{
    public class UserTablesService : IUserTablesService
    {
        private readonly IUserTablesRepository usertableRepository;
        private readonly IContractorRepository contractorRepository;

        private readonly IUnitOfWork unitOfWork;

        public UserTablesService(IUserTablesRepository usertableRepository,IContractorRepository contractorRepository, IUnitOfWork unitOfWork)
        {
            this.contractorRepository = contractorRepository;
            this.usertableRepository = usertableRepository;
            this.unitOfWork = unitOfWork;
        }

        /// <summary>
        /// Getting All Data from Users table
        /// </summary>
        /// <returns></returns>
        public IEnumerable<UserTables> GetAllCustomers()
        {
            try
            {
                return usertableRepository.GetAll();
            }
            catch (Exception)   
            {
                throw;
            }
        }

        /// <summary>
        /// Adding Contractor details into Contractors Table
        /// </summary>
        /// <param name="usertables"></param>
        public void AddUser(ContractorRegistrationViewModel usertables)
        {
            try
            {
               // AspNetUserRoles asp = new AspNetUserRoles { };    
                UserTables njp = new UserTables
                {
                    IsActive = true,
                    CreatedBy = usertables.ContractorName
                };
                usertableRepository.Add(njp);
                unitOfWork.Commit();

                Contractors cts = new Contractors
                {
                    UserTableId = usertables.UserTableId,
                    StateId = usertables.StateId,
                    CityId = usertables.CityId,
                    ContractorName = usertables.ContractorName,
                    ContractorAge = usertables.ContractorAge,
                    ContractorPhone = usertables.ContractorPhone,
                    IsActive = true,
                    CreatedBy = usertables.CreatedBy
                };
                contractorRepository.Add(cts);
                unitOfWork.Commit();
            }
            catch (Exception)
            {
                throw;
            }

        }
    }
}

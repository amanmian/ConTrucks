using Contrucks.model;
using Contrucks.model.ViewModels;
using Contrucks.Repository;
using Contrucks.Repository.Infrastructure;
using Contrucks.Repository.Repository;
using Contrucks.Service.Interfaces;
using System.Collections.Generic;
using System.Net.Mail;
using System;

namespace Contrucks.Service
{
    public class RecentJobPostService : IRecentJobPostService
    {
        private readonly IRecentpostsRepository usertableRepository;
        private readonly ILoadTypesRepository loadtyperepository;     
        private readonly ITruckTypeRepository trucktyperepository;  
        private readonly IUnitOfWork unitOfWork;

        /// <summary>
        /// Initializing reference variables of IRecentpostsRepository and IUnitOfWork
        /// </summary>
        /// <param name="usertableRepository"></param>
        /// <param name="unitOfWork"></param>
        public RecentJobPostService(IRecentpostsRepository usertableRepository, IUnitOfWork unitOfWork,ILoadTypesRepository loadtyperepo,ITruckTypeRepository trucktyperepo)
        {
            loadtyperepository = loadtyperepo;
            trucktyperepository = trucktyperepo;
            this.usertableRepository = usertableRepository;
            this.unitOfWork = unitOfWork;
        }

        /// <summary>
        /// Getting all the data regarding Job Posts Details 
        /// </summary>
        /// <returns></returns>
        public IEnumerable<NewJobPosts> GetAll()
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
        /// Adding another New Job Posts detail into DB
        /// </summary>
        /// <param name="usertables"></param>
        public void AddData(RecentpostViewmodel usertables)
        {
            try
            {
            NewJobPosts njp = new NewJobPosts
          
            {
                    ContractorId = usertables.ContractorId,
                distance = usertables.distance,
                JobTitle = usertables.JobTitle,
                JobDescription = usertables.JobDescription,
                JobStartDate = usertables.JobStartDate,
                JobEndDate = usertables.JobEndDate,
                EstimatedTime = usertables.EstimatedTime,
                SourceAddress = usertables.SourceAddress,
                DestinationAddress = usertables.DestinationAddress,
                LoadWeight = usertables.LoadWeight,
                Budget = usertables.Budget,
                LoadTypeId=usertables.LoadTypeId,
               TruckTypeId=usertables.TruckTypeId
             };
            usertableRepository.Add(njp);
            unitOfWork.Commit();
        }
            catch (Exception)   
            {
                throw;
            }
        }

        /// <summary>
        /// GETTING ALL THE DATA FROM NEW JOB POSTS BASED ON Id
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public NewJobPosts GetAllById(int Id)
        {
            try
            {

                return usertableRepository.GetAllById(Id);

            }
            catch (Exception)   
            {
                throw;
            }
        }

        /// <summary>
        /// GETTING LOAD TYPES FROM DB
        /// </summary>
        /// <returns></returns>
        public IEnumerable<LoadTypes> GetLoadType()
        {
            try
            {
                return loadtyperepository.GetLoadType();
            }
            catch (Exception)   
            {
                throw;
            }
        }

        /// <summary>
        /// GETTING TRUCK TYPES FROM DB
        /// </summary>
        /// <returns></returns>
        public IEnumerable <TruckTypes> GetTruckType()
        {
            try
            {

                return trucktyperepository.GetTruckType();

            }
            catch (Exception)   
            {
                throw;
            }
        }
       
        public IEnumerable<NewJobPosts> GetFulfilledPostsData()
        {
            return usertableRepository.GetFulfilledPostsData();
        }
    }
}
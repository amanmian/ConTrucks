using Contrucks.model;
using Contrucks.model.ViewModels;
using Contrucks.Repository.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contrucks.Repository.Repository
{
  
        public class RecentpostsRepository : RepositoryBase<NewJobPosts>, IRecentpostsRepository
        {
            public RecentpostsRepository(IDatabaseFactory databaseFactory) : base(databaseFactory)
            {
            }

        public NewJobPosts GetAllById(int Id)
        {
                //return Find(Id);     
                return FindBy(x => x.ContractorId == Id).FirstOrDefault();
        }

        
    }
        public interface IRecentpostsRepository : IRepositoryBase<NewJobPosts>
        {
            IEnumerable<NewJobPosts> GetAll();
            void Add(NewJobPosts usertables);
            NewJobPosts GetAllById(int Id);

        IEnumerable<NewJobPosts> GetFulfilledPostsData();
        }

    }


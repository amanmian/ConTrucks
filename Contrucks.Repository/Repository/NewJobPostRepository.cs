using Contrucks.model;
using Contrucks.Repository.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contrucks.Repository.Repository
{
    public class NewJobPostRepository : RepositoryBase<NewJobPosts>, INewJobPostRepository
    {
        public NewJobPostRepository(IDatabaseFactory databaseFactory) : base(databaseFactory)
        {
        }
    }
    public interface INewJobPostRepository : IRepositoryBase<Contractors>
    {
        IEnumerable<NewJobPosts> GetAll();
        void Add(NewJobPosts newJobPosts);
    }
}

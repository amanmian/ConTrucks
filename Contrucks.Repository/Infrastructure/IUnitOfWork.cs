namespace Contrucks.Repository.Infrastructure
{
    public interface IUnitOfWork
    {
        void Commit();
    }
}
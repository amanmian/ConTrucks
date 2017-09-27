namespace Contrucks.Repository.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IDatabaseFactory databaseFactory;
        private ConTruckContext dataContext;
        public UnitOfWork(IDatabaseFactory databaseFactory)
        {
            this.databaseFactory = databaseFactory;
        }
        protected ConTruckContext DataContext
        {
            get { return dataContext ?? (dataContext = databaseFactory.Get()); }
        }
        public void Commit()
        {
            DataContext.Commit();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contrucks.Repository.Infrastructure
{
    public class DatabaseFactory : Disposable, IDatabaseFactory
    {
        private ConTruckContext dataContext;
        public ConTruckContext Get()
        {
            return dataContext ?? (dataContext = new ConTruckContext());
        }
        protected override void DisposeCore()
        {
            if (dataContext != null)
                dataContext.Dispose();
        }
    }
}

using Microsoft.AspNet.Identity.EntityFramework;

namespace Contrucks.model.ViewModels
{
    public class UserTablesViewModel :IdentityDbContext
    {
        public string UserEmail { get; set; }
    
        public string UserPassword { get; set; }
    }
}

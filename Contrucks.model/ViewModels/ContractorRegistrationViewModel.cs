using Microsoft.AspNet.Identity.EntityFramework;

namespace Contrucks.model.ViewModels
{
    public class ContractorRegistrationViewModel :IdentityDbContext
    {
        public virtual string UserEmail { get; set; }
        public virtual string UserPassword { get; set; }
        public virtual int ContractorId { get; set; }
        public virtual int UserTableId { get; set; }
        public virtual int StateId { get; set; }
        public virtual int CityId { get; set; }
        public virtual string ContractorName { get; set; }
        public virtual int ContractorAge { get; set; }
        public virtual string ContractorPhone { get; set; }
        public virtual bool IsActive { get; set; }
        public virtual string CreatedBy { get; set; }
    }
}

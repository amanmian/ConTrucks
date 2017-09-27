using Microsoft.AspNet.Identity.EntityFramework;

namespace Contrucks.model.ViewModels
{
    public class TruckerRegistrationViewModel : IdentityDbContext
    {
        public virtual string UserEmail { get; set; }
        public virtual string UserPassword { get; set; }
        public virtual int TruckerId { get; set; }
        public virtual int UserTableId { get; set; }

        public virtual int StateId { get; set; }
        public virtual int CityId { get; set; }

        public virtual string TruckerName { get; set; }

        public virtual int TruckerAge { get; set; }

        public virtual string TruckerLicensePlate { get; set; }
        public virtual string TruckerPhone { get; set; }
        public virtual bool IsActive { get; set; }
        public virtual string CreatedBy { get; set; }
    }
}

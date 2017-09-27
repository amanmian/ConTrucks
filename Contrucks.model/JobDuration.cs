using System;
using System.ComponentModel.DataAnnotations;

namespace Contrucks.model
{
    public class JobDuration
    {
        [Key]
        public int JobDurationId { get; set; }
        
        //foreign key for Contractors
        public int ContractorId { get; set; }   
        public virtual DateTime JobStartTime { get; set; }
        public virtual DateTime JobStopTime { get; set; }
        public virtual DateTime CreatedDate { get; set; } = DateTime.Now;
        [MaxLength(255)]
        public virtual string CreatedBy { get; set; }
        [MaxLength(255)]
        public virtual string ModifiedBy { get; set; }
        public virtual DateTime? ModifiedDate { get; set; }
        public virtual bool IsActive { get; set; }
        public virtual bool Deleted { get; set; }
        [MaxLength(255)]
        public virtual string DeletedBy { get; set; }
        public virtual DateTime? DeletedDate { get; set; }


        public virtual Contractors Contractor { get; set; }

    }
}

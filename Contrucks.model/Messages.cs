using System;
using System.ComponentModel.DataAnnotations;

namespace Contrucks.model
{
    public class Messages
    {
        [Key]
        public int MessageId { get; set; }

        //foreign key for JobApplications
        public int JobApplicationId { get; set; }
     
        
        [Required]
        [MaxLength(255)]
        public virtual string SenderName { get; set; }
        [MaxLength(300)]
        public virtual string MessageSubject { get; set; }
        [MaxLength(3000)]
        public virtual string MessageBody { get; set; }
        public virtual DateTime MessageDate { get; set; }
        public virtual DateTime CreatedDate { get; set; } = DateTime.Now;
        [MaxLength(255)]
        public virtual string CreatedBy { get; set; }
        [MaxLength(255)]
        public virtual string ModifiedBy { get; set; }
        public virtual DateTime? ModifiedDate { get; set; }
        public virtual bool IsActive { get; set; }
        public virtual bool Deleted { get; set; }
        public virtual string DeletedBy { get; set; }
        public virtual DateTime? DeletedDate { get; set; }


        public virtual JobApplications JobApplications { get; set; }

    }
}

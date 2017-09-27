using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Contrucks.model
{
    public class JobApplications
    {
        [Key]
        public int JobApplicationId { get; set; }

        //foreign key for Truckers
     
        public int TruckerId { get; set; }

        
    

        //foreign key for NewJobPosts
        public int JobId { get; set; }

      
     

        [Required]
        [MaxLength(3000)]
        public virtual string CoverLetter { get; set; }
        [Required(ErrorMessage = "This Field is required")]
        [Range(100, 9999999)]
        public virtual long AskingPrice { get; set; }
        [Required(ErrorMessage = "This Field is required")]
        public virtual DateTime TimeRequired { get; set; }
        public virtual string JobApplicationStatus { get; set; }
        public virtual bool IsJobAwarded { get; set; }

        public virtual bool IsActive { get; set; }
        public virtual DateTime CreatedDate { get; set; } = DateTime.Now;
        public virtual string CreatedBy { get; set; }
        public virtual DateTime? ModifiedDate { get; set; }
        public virtual string ModifiedBy { get; set; }
        public virtual string Deleted { get; set; }
        public virtual string DeletedBy { get; set; }
        public virtual DateTime? DeletedDate { get; set; }

        public virtual ICollection<Messages> Messages { get; set; }


        public virtual Truckers Truckers { get; set; }

        public virtual NewJobPosts NewJobPosts { get; set; }
    }
}

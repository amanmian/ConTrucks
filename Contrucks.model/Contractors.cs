using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Contrucks.model
{
    public class Contractors 
    {
        [Key]
        public int ContractorId { get; set; }

        //foreign key for UserTables
        public int UserTableId { get; set; }

        //foreign key for State

        public int StateId { get; set; }

        //foreign key for City

        public int CityId { get; set; }

        [Required(ErrorMessage = "Name is Required")]
        [MaxLength(255)]
        public virtual string ContractorName { get; set; }

        [Required(ErrorMessage = "Valid Age is Required")]
        [Range(18, 120)]
        public virtual int ContractorAge { get; set; }

        [Required(ErrorMessage = "This Field is Required")]
        [MaxLength(15, ErrorMessage = "Invalid Phone Number")]
        public virtual string ContractorPhone { get; set; }

        public virtual bool IsActive { get; set; }
        public virtual DateTime CreatedDate { get; set; } = DateTime.Now;
        public virtual string CreatedBy { get; set; }
        public virtual DateTime? ModifiedDate { get; set; }
        public virtual string ModifiedBy { get; set; }
        public virtual string Deleted { get; set; }
        public virtual string DeletedBy { get; set; }
        public virtual DateTime? DeletedDate { get; set; }

       
        public virtual ICollection<NewJobPosts> NewJobPosts { get; set; }

        public virtual ICollection<Transactions> Transactions { get; set; }

        public virtual ICollection<JobDuration> JobDuration { get; set; }


//        [NotMapped]
        public virtual UserTables UserTables { get; set; }

        public virtual City City { get; set; }

        public virtual State State { get; set; }



    }
}

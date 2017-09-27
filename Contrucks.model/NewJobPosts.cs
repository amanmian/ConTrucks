using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Contrucks.model
{
    public class NewJobPosts
    {
        [Key]
        public int JobId { get; set; }

        //foreign key for Contractors
        public int? ContractorId { get; set; }



        

        //foreign key for LoadType
        public int? LoadTypeId { get; set; }

        //foreign key for TruckType
        public int? TruckTypeId { get; set; }


       

        [Required(ErrorMessage = "This Field is Required")]
        [Range(0,10000)]
      
        public virtual int distance { get; set; }

        [Required(ErrorMessage = "Please Mention a Title")]
        [MaxLength(255, ErrorMessage = "Word Limit Exceeded")]
        public virtual string JobTitle { get; set; }
        [Required(ErrorMessage = "This field is required")]
        [MaxLength(3000, ErrorMessage = "Word Limit Exceeded")]
        public virtual string JobDescription { get; set; }
        [Required(ErrorMessage = "Start date and time cannot be empty")]

        [DataType(DataType.DateTime)]
        public virtual DateTime? JobStartDate { get; set; }

        [DataType(DataType.DateTime)]
        public virtual DateTime? JobEndDate { get; set; }
        public virtual int EstimatedTime { get; set; }
        [Required(ErrorMessage = "Please Mention a source Address")]
        [MaxLength(500, ErrorMessage = "Word Limit Exceeded")]
        public virtual string SourceAddress { get; set; }
        [Required(ErrorMessage = "Please Mention a Destination Address")]
        [MaxLength(500, ErrorMessage = "Word Limit Exceeded")]
        public virtual string DestinationAddress { get; set; }
        [Required(ErrorMessage = "This field is required")]

        public virtual int LoadWeight { get; set; }
        [Required(ErrorMessage = "This field is required")]
        public virtual int Budget { get; set; }
        [DataType(DataType.DateTime)]
        public virtual DateTime? PostedDate { get; set; } = DateTime.Now;
        public virtual bool IsActive  { get; set; }
        public virtual DateTime CreatedDate { get; set; } = DateTime.Now;
        public virtual string CreatedBy { get; set; }
        public virtual DateTime? ModifiedDate { get; set; }
        public virtual string ModifiedBy { get; set; }
        public virtual string Deleted { get; set; }
        public virtual string DeletedBy { get; set; }
        public virtual DateTime? DeletedDate { get; set; }

        public virtual ICollection<JobApplications> JobApplications { get; set; }



        public virtual Contractors Contractor { get; set; }

        public virtual LoadTypes LoadTypes { get; set; }
        public virtual TruckTypes TruckType { get; set; }
    }
}

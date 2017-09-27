using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Contrucks.model
{
    public class Truckers
    {

        [Key]
        public int TruckerId { get; set; }

        //foreign key for UserTables
        public int UserTableId { get; set; }

      
      
        //foreign key for States
        public int StateId { get; set; }

      
     

        //foreign key for City
        public int CityId { get; set; }

       
      

        [Required(ErrorMessage = "Trucker's Name is Required")]
        [MaxLength(255, ErrorMessage = "Word limit Exceeded")]
        public virtual string TruckerName { get; set; }

        [Required(ErrorMessage = "This Field is Required")]
        [Range(18, 110)]
        public virtual int TruckerAge { get; set; }

        [Required(ErrorMessage = "This Field is Required")]
        [MaxLength(20, ErrorMessage = "Limit Exceeded")]

        public virtual string TruckerLicensePlate { get; set; }

        [Required(ErrorMessage = "This Field is Required")]
        [MaxLength(15, ErrorMessage = "Invalid Phone Number")]
        public virtual string TruckerPhone { get; set; }
        public virtual bool IsActive { get; set; }
        public virtual DateTime CreatedDate { get; set; } = DateTime.Now;
        public virtual string CreatedBy { get; set; }
        public virtual DateTime? ModifiedDate { get; set; }
        public virtual string ModifiedBy { get; set; }
        public virtual string Deleted { get; set; }
        public virtual string DeletedBy { get; set; }
        public virtual DateTime? DeletedDate { get; set; }

   
        public virtual ICollection<Messages> Messages { get; set; }

        public virtual ICollection<TruckerDetail> TruckerDetail { get; set; }



        public virtual UserTables UserTable { get; set; }

        public virtual State State { get; set; }

        public virtual City City { get; set; }

    }
}

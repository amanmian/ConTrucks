using System;
using System.ComponentModel.DataAnnotations;

namespace Contrucks.model
{
    public class TruckerDetail
    {
        [Key]
        public int TruckId { get; set; }

        //foreign key for Truckers
        public int TruckerId { get; set; }

      
       

        //foreign key for TruckType
        public int TruckTypeId { get; set; }

        
       

        [Required]
        [MaxLength(255, ErrorMessage = "Invalid Registration Number")]
        public virtual string TruckNumber { get; set; }

        [Required, Range(1, 300)]
        [RegularExpression(@"\d+(\.\d{1,2})?", ErrorMessage = "Invalid Values")]
        public virtual decimal TruckMileage { get; set; }

        [Required, Range(1, 1000)]
        [RegularExpression(@"\d+(\.\d{1,2})?", ErrorMessage = "Invalid Values")]
        public virtual decimal MaximumWeightBearable { get; set; }

        [Required, Range(4, 100)]
        public virtual int NumberOfWheels { get; set; }

        public virtual DateTime TruckBoughtIn { get; set; }

        public virtual bool IsActive { get; set; }
        public virtual DateTime CreatedDate { get; set; } = DateTime.Now;
        public virtual string CreatedBy { get; set; }
        public virtual DateTime? ModifiedDate { get; set; }
        public virtual string ModifiedBy { get; set; }
        public virtual string Deleted { get; set; }
        public virtual string DeletedBy { get; set; }
        public virtual DateTime? DeletedDate { get; set; }


        public virtual Truckers Truckers { get; set; }

        public virtual TruckTypes TruckType { get; set; }
    }
}

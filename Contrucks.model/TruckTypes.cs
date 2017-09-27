using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Contrucks.model
{
    public class TruckTypes
    {
        [Key]
        public int TruckTypeId { get; set; }
        [Required]
        [MaxLength(255)]
        public virtual string Trucktype { get; set; }
        public virtual bool IsActive { get; set; }
        public virtual DateTime CreatedDate { get; set; } = DateTime.Now;
        public virtual string CreatedBy { get; set; }
        public virtual DateTime? ModifiedDate { get; set; }
        public virtual string ModifiedBy { get; set; }
        public virtual string Deleted { get; set; }
        public virtual string DeletedBy { get; set; }
        public virtual DateTime? DeletedDate { get; set; }
     

        public virtual ICollection<TruckerDetail> TruckerDetail { get; set; }
    }
}
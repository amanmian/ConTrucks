using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace Contrucks.model
{
    public class City
    {
        [Key]
        public int CityId { get; set; }

        //foreign key for States
        public int StateId { get; set; }
        public virtual string CityName { get; set; }
        public virtual bool IsActive { get; set; }
        public virtual DateTime CreatedDate { get; set; } = DateTime.Now;
        public virtual string CreatedBy { get; set; }
        public virtual DateTime? ModifiedDate { get; set; }
        public virtual string ModifiedBy { get; set; }
        public virtual string Deleted { get; set; }
        public virtual string DeletedBy { get; set; }
        public virtual DateTime? DeletedDate { get; set; }

        public virtual State State { get; set; }
        public virtual ICollection<Truckers> Truckers { get; set; }
        public virtual ICollection<Contractors> Contractors { get; set; }
       
    }
}

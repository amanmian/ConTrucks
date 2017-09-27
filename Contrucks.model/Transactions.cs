using System;
using System.ComponentModel.DataAnnotations;

namespace Contrucks.model
{
    public class Transactions
    {
        [Key]
        public int TransactionId { get; set; }

        //foreign key for Contractors
        public int ContractorId { get; set; }

      
       

        //foreign key for Truckers
        public int TruckerId { get; set; }


    
        [MaxLength(15)]
        public virtual string TransactionStatus { get; set; }
        public virtual bool IsActive { get; set; }
        public virtual DateTime CreatedDate { get; set; } = DateTime.Now;
        public virtual string CreatedBy { get; set; }
        public virtual DateTime? ModifiedDate { get; set; }
        public virtual string ModifiedBy { get; set; }
        public virtual string Deleted { get; set; }
        public virtual string DeletedBy { get; set; }
        public virtual DateTime? DeletedDate { get; set; }


        public virtual Contractors Contractor { get; set; }

        public virtual Truckers Trucker { get; set; }
    }
}

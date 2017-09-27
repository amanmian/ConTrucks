using System;
using System.ComponentModel.DataAnnotations;

namespace Contrucks.model
{
    public class Balance
    {
        [Key]
        public int BalanceId { get; set; }

        //foreign key for UserTables
        public int UserTableId { get; set; }

       [Required]
        public virtual int Amount { get; set; }
        [Required]
        public virtual DateTime CreatedDate { get; set; } = DateTime.Now;
        [MaxLength(255)]
        public string CreatedBy { get; set; }
        [MaxLength(255)]
        public virtual string ModifiedBy { get; set; }
        public virtual DateTime? ModifiedDate { get; set; }
        public virtual bool IsActive { get; set; }
        public virtual bool Deleted { get; set; }
        [MaxLength(255)]
        public virtual string DeletedBy { get; set; }
        public virtual DateTime? DeletedDate { get; set; }


        public virtual UserTables UserTables { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Contrucks.model
{
    public class LoadTypes
    {
        [Key]
        public int LoadTypeId { get; set; }
        public string LoadName { get; set; }
        public virtual bool IsActive { get; set; }
        public virtual DateTime CreatedDate { get; set; } = DateTime.Now;
        public virtual string CreatedBy { get; set; }
        public virtual DateTime? ModifiedDate { get; set; }
        public virtual string ModifiedBy { get; set; }
        public virtual string Deleted { get; set; }
        public virtual string DeletedBy { get; set; }
        public virtual DateTime? DeletedDate { get; set; }

        public virtual ICollection<NewJobPosts> NewJobPosts { get; set; }
    }
}
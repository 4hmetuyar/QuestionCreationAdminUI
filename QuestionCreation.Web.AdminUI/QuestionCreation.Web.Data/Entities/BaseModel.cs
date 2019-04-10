using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuestionCreation.Web.Data.Entities
{
    public class BaseModel
    {
        public int Id { get; set; }
        [ForeignKey("CreatedUser")]
        public int? CreatedBy { get; set; }

        private DateTime? createdDate;

        [Required]
        public DateTime CreatedDate
        {
            get
            {
                if (createdDate == null)
                {
                    createdDate = DateTime.Now;
                }
                return createdDate.Value;
            }
            set { createdDate = value; }
        }


        [ForeignKey("UpdatedUser")]
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        [DefaultValue("True")]
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }


        //public virtual User CreatedUser { get; set; }
        //public virtual User UpdatedUser { get; set; }

    }
}

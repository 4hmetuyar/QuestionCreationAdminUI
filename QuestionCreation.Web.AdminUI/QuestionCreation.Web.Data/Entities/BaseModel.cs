using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuestionCreation.Web.Data.Entities
{
    public class BaseModel
    {
        public int Id { get; set; }
       

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


      
        public DateTime? UpdatedDate { get; set; }
        [DefaultValue("True")]
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }


 

    }
}

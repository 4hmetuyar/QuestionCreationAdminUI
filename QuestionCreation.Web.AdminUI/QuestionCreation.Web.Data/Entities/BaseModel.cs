using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace QuestionCreation.Web.Data.Entities
{
    public class BaseModel
    {
        public int Id { get; set; }
       

        private DateTime? _createdDate;

        [Required]
        public DateTime CreatedDate
        {
            get
            {
                if (_createdDate == null)
                {
                    _createdDate = DateTime.Now;
                }
                return _createdDate.Value;
            }
            set => _createdDate = value;
        }
      
        public DateTime? UpdatedDate { get; set; }
        [DefaultValue("True")]
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        
    }
}

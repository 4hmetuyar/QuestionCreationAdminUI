using QuestionCreation.Web.Data.Entities;
using System.Collections.Generic;

namespace QuestionCreation.Web.Domain.ViewModel
{

    public class UserViewModel : BaseViewModel
    {
        public List<User> Users { get; set; }
    }
}

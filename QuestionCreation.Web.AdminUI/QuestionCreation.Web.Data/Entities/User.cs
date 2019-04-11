namespace QuestionCreation.Web.Data.Entities
{
    public class User : BaseModel
    {
        public string UserName { get; set; }

        public string Password { get; set; }
    }
}

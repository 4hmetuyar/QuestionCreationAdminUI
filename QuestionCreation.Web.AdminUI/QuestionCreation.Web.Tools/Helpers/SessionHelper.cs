using System;
using System.Web;

namespace QuestionCreation.Web.Tools.Helpers
{
    [Serializable]
    public class SessionHelper
    {
        // private constructor
        private SessionHelper()
        {

        }

        // Gets the current session.
        public static SessionHelper Current
        {
            get
            {
                SessionHelper session =
                  (SessionHelper)HttpContext.Current.Session["__CurrentUserId__"];
                if (session == null)
                {
                    session = new SessionHelper();
                    HttpContext.Current.Session["__CurrentUserId__"] = session;
                }
                return session;
            }
        }

        // **** add your session properties here, e.g like this:
        public int UserId { get; set; }
    }
}

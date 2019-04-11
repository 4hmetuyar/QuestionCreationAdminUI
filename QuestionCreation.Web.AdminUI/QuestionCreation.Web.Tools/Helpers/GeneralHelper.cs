namespace QuestionCreation.Web.Tools.Helpers
{
    public static class GeneralHelper
    {
        /// <summary>
        /// Eğer stringe dönüştürülmek istenen değer null ise exception fırlatmaz, string.empty değer döner.
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static string ToNCString(this object obj)
        {
            return obj == null ? string.Empty : obj.ToString();
        }

        /// <summary>
        /// Eğer int'e dönüştürülmek istenen değer null veya integer formatında değilse exception fırlatmaz, 0 döner.
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static int ToNCInt(this object obj)
        {
            int val;
            int.TryParse(obj.ToNCString(), out val);
            return val;
        }

        public static string ReplaceForGrid(this object item)
        {
            return item.ToNCString().Replace(" ", string.Empty).Replace(" ", string.Empty).Replace("E.", string.Empty).Replace(".", string.Empty).Replace(",", string.Empty).Replace("-", string.Empty).Replace("(", string.Empty).Replace(")", string.Empty).Replace("/", string.Empty);
        }
    }
}

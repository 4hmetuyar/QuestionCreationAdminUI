using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public static RouteValueDictionary ToRouteValues(this NameValueCollection queryString)
        {
            if (queryString == null || queryString.HasKeys() == false) return new RouteValueDictionary();

            var routeValues = new RouteValueDictionary();
            foreach (string key in queryString.AllKeys)
                routeValues.Add(key, queryString[key]);

            return routeValues;
        }

        public static string ReplaceEmailVariables(this string text, MailParameters parameters)
        {
            return text.Replace("{ID}", parameters.AdvertisementId.ToNCString())
                .Replace("{DEALER}", parameters.Dealer)
                .Replace("{URL}", parameters.Url)
                .Replace("{REASON}", parameters.Reason)
                .Replace("{USER}", parameters.User)
                .Replace("{TITLE}", parameters.AdvertisementTitle)
                .Replace("{MESSAGE}", parameters.Message)
                .Replace("{PRICE}", parameters.Price.ToNCString())
                .Replace("{CURRENCY}", parameters.Currency)
                .Replace("{EMAIL}", parameters.Email)
                .Replace("{NAMESURNAME}", parameters.NameSurName)
                .Replace("{PHONE}", parameters.Phone)
                .Replace("{SUBJECT}", parameters.Subject)
                .Replace("{USERNAME}", parameters.UserName)
                .Replace("{ADMINSITEURL}", parameters.AdminSiteUrl)
                .Replace("{WEBSITEURL}", parameters.WebSiteUrl)
                .Replace("{PASSWORD}", parameters.Password)
                ;
        }

        public static object FormatString(this object text, int? formatType)
        {
            try
            {
                if (formatType == (int)FormatType.Date || formatType == (int)FormatType.DateTime)
                {
                    DateTime date = Convert.ToDateTime(text);

                    switch (formatType)
                    {
                        case (int)FormatType.Date:
                            return $"{date:dd.MM.yyyy}";
                        case (int)FormatType.DateTime:
                            return $"{date:dd.MM.yyyy HH:mm}";
                    }
                }
                else if (formatType > 0)
                {
                    decimal value = Convert.ToDecimal(text);
                    if (value == 0)
                    {
                        return null;
                    }
                    switch (formatType)
                    {
                        case (int)FormatType.Integer:
                            return $"{value:.##}";
                        case (int)FormatType.OnlyDecimal:
                            return $"{value:0.00}";
                        case (int)FormatType.ThousandSeperator:
                            return $"{value:#,##0}";
                        case (int)FormatType.ThousandSeperatorWithDecimal:
                            return $"{value:#,##0.00}";
                    }
                }
            }
            catch
            {
                return text;
            }

            return text;

        }

        public static string ReplaceForGrid(this object item)
        {
            return item.ToNCString().Replace(" ", string.Empty).Replace(" ", string.Empty).Replace("E.", string.Empty).Replace(".", string.Empty).Replace(",", string.Empty).Replace("-", string.Empty).Replace("(", string.Empty).Replace(")", string.Empty).Replace("/", string.Empty);
        }
    }
}

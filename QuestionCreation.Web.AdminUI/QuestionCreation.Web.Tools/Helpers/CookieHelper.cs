using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionCreation.Web.Tools.Helpers
{
    public static class CookieHelper
    {
        public const string LastVisitedProducts = "LastVisitedProducts";

        /// <summary>
        /// Kullanıcının en son ziyaret ettiği ürünleri cookie'ye ekler.
        /// </summary>
        /// <param name="id">Ürün ID'si</param>
        public static void AddProductToLastVisited(string id)
        {
            HttpCookie lastVisitedProducts = HttpContext.Current.Request.Cookies[LastVisitedProducts];
            if (lastVisitedProducts != null)
            {
                var products = lastVisitedProducts.Value.Split(',').ToList();
                products.Insert(0, id);
                lastVisitedProducts.Value = string.Join(",", products);
            }
            else
            {
                lastVisitedProducts = new HttpCookie(LastVisitedProducts);
                lastVisitedProducts.Value = id;
            }

            lastVisitedProducts.Expires = DateTime.Now.AddHours(1);
            HttpContext.Current.Response.Cookies.Add(lastVisitedProducts);
        }

        /// <summary>
        /// En son ziyaret edilen ürünleri getirir.
        /// </summary>
        /// <param name="currentProductId">O an görüntülenen ürün ID'si. İlan detayında gösterirken o anki ürünü getirmesin diye kullanıyoruz.</param>
        /// <returns></returns>
        public static List<int> GetLastVisitedProducts(int? currentProductId)
        {
            var products = new List<int>();
            try
            {
                HttpCookie lastVisitedProducts = HttpContext.Current.Request.Cookies[LastVisitedProducts];
                if (lastVisitedProducts != null)
                {
                    var values = lastVisitedProducts.Value.Split(',').ToList().Distinct();
                    products = values.Select(int.Parse).Where(x => x != currentProductId).ToList();
                }
            }
            catch (Exception)
            {

            }

            return products;
        }
    }
}

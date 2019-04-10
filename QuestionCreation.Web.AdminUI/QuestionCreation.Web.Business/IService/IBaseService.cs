using System;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace QuestionCreation.Web.Business.IService
{
    public interface IBaseService<T, VM>
    {
        Task<T> GetByIdAsync(int Id);

        VM GetAll(bool activeOnly = false);

        VM GetAll(int pageNumber, int pageSize = 0, bool activeOnly = false);

        /// <summary>
        /// LINQ sorgusunu parametre olarak alır, uygun sonuçları getirir.
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        VM GetByQuery(Expression<Func<T, bool>> predicate);

        Task<int> Update(T model);

        Task<int> Create(T model);

        Task<int> Delete(T model);

        Task<int> Delete(int Id);

        int GetTotalCount(bool activeOnly = false);
    }
}

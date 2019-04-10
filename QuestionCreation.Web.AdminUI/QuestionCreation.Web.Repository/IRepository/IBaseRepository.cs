using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace QuestionCreation.Web.Repository.IRepository
{
    public interface IBaseRepository<T, VM>
    {
        Task<T> GetByIdAsync(int Id);

        List<T> GetAll(bool activeOnly = false);

        List<T> GetAll(int page, int pageSize, out int PageCount, bool activeOnly = false);

        /// <summary>
        /// LINQ sorgusunu parametre olarak alır, uygun sonuçları getirir.
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        List<T> GetByQuery(Expression<Func<T, bool>> predicate);

        Task<int> Update(T model);

        Task<int> Create(T model);

        Task<int> Delete(T model);

        Task<int> Delete(int Id);

        int GetTotalCount(bool activeOnly = false);
    }
}

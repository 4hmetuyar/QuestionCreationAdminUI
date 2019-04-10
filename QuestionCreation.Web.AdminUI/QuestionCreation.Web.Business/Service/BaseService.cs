using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionCreation.Web.Business.Service
{
    public class BaseService<T, VM> : IBaseService<T, VM> where T : BaseModel, new() where VM : BaseViewModel
    {
        private readonly IBaseRepository<T, VM> _repository;
        public BaseService(IBaseRepository<T, VM> repository)
        {
            _repository = repository;
        }

        public virtual async Task<T> GetByIdAsync(int Id)
        {
            return await _repository.GetByIdAsync(Id);
        }

        public virtual VM GetAll(bool activeOnly = false)
        {
            List<T> result = _repository.GetAll(activeOnly).ToList();
            VM resultVM = AutoMapper.Mapper.Map<List<T>, VM>(result);
            return resultVM;
        }

        public VM GetByQuery(Expression<Func<T, bool>> predicate)
        {
            List<T> result = _repository.GetByQuery(predicate).ToList();
            VM resultVM = AutoMapper.Mapper.Map<List<T>, VM>(result);
            return resultVM;
        }

        /// <summary>
        /// Tümünü sayfalı olarak getirir. PageSize göndermezseniz default değeri kullanır.
        /// </summary>
        /// <param name="pageNumber">sayfa numarası</param>
        /// <param name="activeOnly">yalnız aktif olanları mı?</param>
        /// <param name="pageSize">Gönderilmezse default değer kullanılır.</param>
        /// <returns></returns>
        public VM GetAll(int pageNumber, int pageSize = 0, bool activeOnly = false)
        {
            int pageCount = 0;
            List<T> result = _repository.GetAll(pageNumber, pageSize, out pageCount, activeOnly);
            VM resultVM = AutoMapper.Mapper.Map<List<T>, VM>(result);
            resultVM.PageCount = pageCount;
            return resultVM;
        }

        public virtual async Task<int> Update(T model)
        {
            return await _repository.Update(model);
        }

        public virtual async Task<int> Create(T model)
        {
            return await _repository.Create(model);
        }

        public virtual async Task<int> Delete(T model)
        {
            return await _repository.Delete(model);
        }

        public virtual async Task<int> Delete(int Id)
        {
            return await _repository.Delete(Id);
        }

        public virtual int GetTotalCount(bool activeOnly = false)
        {
            return _repository.GetTotalCount(activeOnly);
        }

    }
}

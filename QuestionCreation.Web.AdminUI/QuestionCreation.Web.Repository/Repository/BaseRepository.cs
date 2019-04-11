using QuestionCreation.Web.Data.Entities;
using QuestionCreation.Web.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using QuestionCreation.Web.Data;
using QuestionCreation.Web.Domain.ViewModel;
using QuestionCreation.Web.Tools.Helpers;

namespace QuestionCreation.Web.Repository.Repository
{
    public class BaseRepository<T, VM> : IBaseRepository<T, VM> where T : BaseModel, new() where VM : BaseViewModel
    {
        private readonly DataContext _context;
        private readonly DbSet<T> _dbSet;

        public BaseRepository(DataContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }

        public virtual async Task<T> GetByIdAsync(int id)
        {
            T result = await _dbSet.Where(x => x.Id == id && !x.IsDeleted).FirstOrDefaultAsync() ?? new T();

            return result;
        }

        public virtual List<T> GetAll(bool activeOnly = false)
        {
            IQueryable<T> query = _dbSet.Where(x => !x.IsDeleted);

            if (activeOnly)
            {
                query = query.Where(x => x.IsActive);
            }

            var result = query.ToList();

            return result;

        }

        public List<T> GetByQuery(Expression<Func<T, bool>> predicate)
        {
            return _dbSet.Where(x => !x.IsDeleted).Where(predicate).ToList();
        }

        public IQueryable GetBaseQuery()
        {
            return _dbSet.Where(x => !x.IsDeleted);
        }

        public List<T> GetAll(int page, int pageSize, out int PageCount, bool activeOnly = false)
        {
            if (pageSize == 0)
            {
                pageSize = 10;
            }

            IQueryable<T> result = _dbSet.Where(x => !x.IsDeleted);

            if (activeOnly)
            {
                result = result.Where(x => x.IsActive);
            }

            int itemsCount = result.Count();

            result = result.OrderBy(x => x.Id).Skip((page - 1) * pageSize).Take(pageSize);

            PageCount = (itemsCount / pageSize);

            if (itemsCount > 0 && itemsCount % pageSize != 0)
            {
                PageCount++;
            }

            return result.ToList();
        }


        public virtual async Task<int> Update(T model)
        {

            model.UpdatedDate = DateTime.Now;
          

            var entity = _dbSet.Find(model.Id);
            if (entity == null)
            {
                return 0;
            }

            _context.Entry(entity).CurrentValues.SetValues(model);

            await SaveChangesAsync();
            return model.Id;
        }

        public virtual async Task<int> Create(T model)
        {

            model.CreatedDate = DateTime.Now;
           


            var result = _dbSet.Add(model);
            await SaveChangesAsync();
            return result.Id;
        }

        public virtual async Task<int> Delete(T model)
        {
            if (model == null)
                return 0;

            _context.Entry(model).Entity.UpdatedDate = DateTime.Now;
            _context.Entry(model).Entity.IsDeleted = true;
            _context.Entry(model).Entity.IsActive = false;

            await SaveChangesAsync();
            return model.Id;
        }

        public virtual async Task<int> Delete(int id)
        {
            var model = _dbSet.FirstOrDefault(x => x.Id == id && !x.IsDeleted);
            return await Delete(model);
        }

        public virtual int GetTotalCount(bool activeOnly = false)
        {
            IQueryable<T> result = _dbSet.Where(x => !x.IsDeleted);

            if (activeOnly)
            {
                result = result.Where(x => x.IsActive);
            }

            return result.Count();
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }

    }
}

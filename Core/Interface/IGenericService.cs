using Core.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interface
{
    public interface IGenericService<T> where T : class
    {
        Task<List<T>> GetAllAsync();
        Task<PagerViewModel<T>> GetAllByPageSizeAsync(int page);
        Task<T> GetByIdAsync(Guid id);
        Task<T> AddAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(T entity);
    }
}

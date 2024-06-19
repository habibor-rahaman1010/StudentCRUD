using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interface
{
    public interface IBlogPost : IGenericService<BlogPostTable>
    {
        //Task<List<BlogPostTable>> GetIncludeAllAsync();
        Task<BlogPostTable> GetDetailsByIdAsync(Guid id);
    }
}

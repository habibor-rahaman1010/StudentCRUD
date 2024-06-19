using Core.Entities;
using Core.Interface;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services
{
    public class BlogPostService : GenericService<BlogPostTable>, IBlogPost
    {
        public BlogPostService(ApplicationDbContext context) : base(context)
        {
        }
        public async Task<BlogPostTable> GetDetailsByIdAsync(Guid id)
        {
            return await _context.BlogPosts.Include(x => x.Category).FirstOrDefaultAsync(c => c.Id == id);
        }
    }
}

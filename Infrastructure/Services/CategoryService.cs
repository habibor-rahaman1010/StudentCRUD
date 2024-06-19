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
    public class CategoryService : GenericService<CategoryTable>, ICategory
    {
        public CategoryService(ApplicationDbContext context) : base(context)
        {
        }
        public async Task<List<BlogPostTable>> GetPostsByCategoryId(Guid categoryId)
        {
            var posts = await _context.BlogPosts
                .Include(post => post.Category)
                .Where(post => post.CategoryId == categoryId)
                .ToListAsync();

            return posts;
        }
    }
}

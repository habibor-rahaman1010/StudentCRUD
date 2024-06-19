using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.ViewModel
{
    public class CategoryPostsViewModel
    {
        public string? CategoryName { get; set; }
        public IEnumerable<BlogPostTable>? Posts { get; set; }
    }

}

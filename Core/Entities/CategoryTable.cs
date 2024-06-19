using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class CategoryTable
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string CategoryName { get; set; } =string.Empty;
        public List<BlogPostTable> BlogPosts { get; set; } = new List<BlogPostTable>();
    }
}

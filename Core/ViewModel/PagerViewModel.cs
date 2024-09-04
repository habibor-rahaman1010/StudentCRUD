using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.ViewModel
{
    public class PagerViewModel<T>
    {
        public List<T> Students { get; set; } = new List<T>();
        public List<T> Blogs { get; set; } = new List<T>();
        public string SearchQuery { get; set; } = string.Empty;
        public Pager? Pager { get; set; }
    }
}

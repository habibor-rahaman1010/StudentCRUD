using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.ViewModel
{
    public class AddStudentViewModel
    {
        public string Name { get; set; } = string.Empty;
        public int Gender { get; set; }
        public DateTime DOB { get; set; }
        public DateTime CreatedDate { get; set; }
        public int ClassId { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.ViewModel
{
    public class EditUserRolesViewModel
    {
        public string UserId { get; set; }
        public string Email { get; set; }
        public List<RoleSelectionViewModel> Roles { get; set; } = new List<RoleSelectionViewModel>();
    }
}

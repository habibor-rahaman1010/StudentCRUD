using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using Core.Entities;
using System.Threading.Tasks;
using System.Linq;
using Core.ViewModel;
using Microsoft.AspNetCore.Authorization;

namespace StudentCURD.Controllers
{
    [Authorize(Roles = "SUPERADMIN")]
    public class RoleManagementController : Controller
    {

        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly SignInManager<ApplicationUser> _signInManager;

        public RoleManagementController(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager, SignInManager<ApplicationUser> signInManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _signInManager = signInManager;
        }

        public async Task<IActionResult> Index()
        {
            var users = _userManager.Users.ToList();
            var userRolesViewModel = new List<UserRolesViewModel>();

            foreach (ApplicationUser user in users)
            {
                var thisViewModel = new UserRolesViewModel();
                thisViewModel.UserId = user.Id;
                thisViewModel.Email = user.Email;
                thisViewModel.Roles = await _userManager.GetRolesAsync(user);
                userRolesViewModel.Add(thisViewModel);
            }

            return View(userRolesViewModel);
        }

        // GET: RoleManagement/Edit
        public async Task<IActionResult> Edit(string userId)
        {
            var user = await _userManager.FindByIdAsync(userId);
            if (user == null)
            {
                return NotFound();
            }

            var userRoles = await _userManager.GetRolesAsync(user);
            var allRoles = _roleManager.Roles.ToList();
            var model = new EditUserRolesViewModel
            {
                UserId = user.Id,
                Email = user.Email,
                Roles = allRoles.Select(role => new RoleSelectionViewModel
                {
                    RoleName = role.Name,
                    IsSelected = userRoles.Contains(role.Name)
                }).ToList()
            };

            return View(model);
        }

        // POST: RoleManagement/Edit
        [HttpPost]
        public async Task<IActionResult> Edit(EditUserRolesViewModel model)
        {
            var user = await _userManager.FindByIdAsync(model.UserId);
            if (user == null)
            {
                return NotFound();
            }

            var userRoles = await _userManager.GetRolesAsync(user);
            var selectedRoles = model.Roles.Where(x => x.IsSelected).Select(y => y.RoleName).ToList();
            var result = await _userManager.AddToRolesAsync(user, selectedRoles.Except(userRoles));

            if (!result.Succeeded)
            {
                ModelState.AddModelError("", "Failed to add roles.");
                return View(model);
            }

            result = await _userManager.RemoveFromRolesAsync(user, userRoles.Except(selectedRoles));

            if (!result.Succeeded)
            {
                ModelState.AddModelError("", "Failed to remove roles.");
                return View(model);
            }
            //await _signInManager.RefreshSignInAsync(user);
            return RedirectToAction("Index");
        }
    }
}

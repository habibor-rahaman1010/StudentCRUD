using Core.Entities;
using Core.Interface;
using Core.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace StudentCURD.Controllers
{
    public class BlogCategoryController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public BlogCategoryController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IActionResult> List()
        {
            return View(await _unitOfWork.Category.GetAllAsync());
        }

        [Authorize(Roles = "admin")]
        public IActionResult Create()
        {
            return View();
        }

        [Authorize(Roles = "admin")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CategoryTable category)
        {
            if (ModelState.IsValid)
            {
                category.Id = Guid.NewGuid();
                await _unitOfWork.Category.AddAsync(category);
                await _unitOfWork.CommitAsync();
                return RedirectToAction(nameof(List));
            }
            else
            {
                return View(category);
            }
        }

        public async Task<IActionResult> GetBlogPostByCategoryWise(Guid categoryId)
        {
            var posts = await _unitOfWork.Category.GetPostsByCategoryId(categoryId);

            var categoryName = await _unitOfWork.Category.GetByIdAsync(categoryId);
            var viewModel = new CategoryPostsViewModel
            {
                CategoryName = categoryName.CategoryName,
                Posts = posts
            };

            return View(viewModel);
        }

        [Authorize(Roles = "admin")]
        public async Task<IActionResult> Update(Guid id)
        {
            var category = await _unitOfWork.Category.GetByIdAsync(id);
            return View(category);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "admin")]
        public async Task<IActionResult> Update(Guid id, CategoryTable category)
        {
            if (ModelState.IsValid)
            {
                var existingCategory = await _unitOfWork.Category.GetByIdAsync(id);
                if (existingCategory != null && category != null)
                {
                    existingCategory.CategoryName = category.CategoryName;
                    await _unitOfWork.CommitAsync();
                    return RedirectToAction(nameof(List));
                }
                return View(category);
            }
            else
            {
                return View(category);
            }
        }

        [HttpPost]
        [Authorize(Roles = "admin")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var existingCategory = await _unitOfWork.Category.GetByIdAsync(id);
            if (existingCategory != null)
            {
                await _unitOfWork.Category.DeleteAsync(existingCategory);
                await _unitOfWork.CommitAsync();
                return RedirectToAction(nameof(List));
            }
            return BadRequest($"This is {id} not exist");
        }
    }
}

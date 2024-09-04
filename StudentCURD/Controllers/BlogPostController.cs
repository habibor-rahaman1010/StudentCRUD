using Core.Entities;
using Core.Interface;
using Core.ViewModel;
using Infrastructure;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Reflection.Metadata;

namespace StudentCURD.Controllers
{
    public class BlogPostController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public BlogPostController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        /*public async Task<IActionResult> List(int page = 1)
        {
            var allBlogs = await _unitOfWork.BlogPost.GetAllByPageSizeAsync(page);
            return View(allBlogs);
        }
        */

        public async Task<IActionResult> List(string searchQuery, int page = 1)
        {
            var paginatedResult = await _unitOfWork.BlogPost.GetAllByPageSizeAsync(page);

            if (!string.IsNullOrEmpty(searchQuery))
            {
                paginatedResult.Blogs = paginatedResult.Blogs
                    .Where(b => b.Title.Contains(searchQuery, StringComparison.OrdinalIgnoreCase) ||
                                b.Content.Contains(searchQuery, StringComparison.OrdinalIgnoreCase))
                    .ToList();
            }

            var model = new PagerViewModel<BlogPostTable>
            {
                Blogs = paginatedResult.Blogs.ToList(),
                SearchQuery = searchQuery,
                Pager = new Pager(paginatedResult.Blogs.Count(), page, 12)
            };
            paginatedResult.SearchQuery = string.Empty;

            return View(model);
        }


        [Authorize(Roles = "SUPERADMIN, ADMIN")]
        public async Task<IActionResult> Create()
        {
            ViewBag.Categories = new SelectList(await _unitOfWork.Category.GetAllAsync(), "Id", "CategoryName");
            return View();
        }

        [Authorize(Roles = "SUPERADMIN, ADMIN")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(BlogPostTable blogPost)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    blogPost.Id = Guid.NewGuid();
                    blogPost.Created = DateTime.Now;
                    blogPost.Updated = DateTime.Now;
                    await _unitOfWork.BlogPost.AddAsync(blogPost);
                    await _unitOfWork.CommitAsync();
                    return RedirectToAction(nameof(List));
                }
                else
                {
                    ViewBag.Categories = new SelectList(await _unitOfWork.Category.GetAllAsync(), "Id", "CategoryName");
                    return View(blogPost);
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        public async Task<IActionResult> Details(BlogPostTable post) 
        {
            if (_unitOfWork.BlogPost != null)
            {
                BlogPostTable? blogPost = await _unitOfWork.BlogPost.GetDetailsByIdAsync(post.Id);
                if (blogPost != null)
                {
                    return View(blogPost);
                }
            }
            return View();
        }

        [Authorize(Roles = "SUPERADMIN")]
        public async Task<IActionResult> Update(Guid id)
        {
            var post = await _unitOfWork.BlogPost.GetByIdAsync(id);
            ViewBag.Categories = new SelectList(await _unitOfWork.Category.GetAllAsync(), "Id", "CategoryName");
            return View(post);
        }

        [Authorize(Roles = "SUPERADMIN")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(BlogPostTable post)
        {
            if (_unitOfWork.BlogPost != null)
            {
                BlogPostTable? existingPost = await _unitOfWork.BlogPost.GetByIdAsync(post.Id);
                if (existingPost is not null)
                {
                    existingPost.CategoryId = post.CategoryId;
                    existingPost.Title = post.Title;
                    existingPost.Content = post.Content;
                    existingPost.Author = post.Author;
                    existingPost.Updated = DateTime.Now;
                    await _unitOfWork.CommitAsync();
                }
                return RedirectToAction(nameof(List));
            }
            return View();
        }

        [Authorize(Roles = "SUPERADMIN")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(Guid id)
        {
            var post = await _unitOfWork.BlogPost.GetByIdAsync(id);
            if (post != null)
            {
                await _unitOfWork.BlogPost.DeleteAsync(post);
                await _unitOfWork.CommitAsync();
                return RedirectToAction(nameof(List));
            }
            return BadRequest();
        }
    }
}

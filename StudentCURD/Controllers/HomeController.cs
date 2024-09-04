using Core.Entities;
using Core.Interface;
using Core.ViewModel;
using Microsoft.AspNetCore.Mvc;
using StudentCURD.Models;
using System.Diagnostics;

namespace StudentCURD.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IUnitOfWork _unitOfWork;

        public HomeController(ILogger<HomeController> logger, IUnitOfWork unitOfWork)
        {
            this._logger = logger;
            this._unitOfWork = unitOfWork;
        }

        /*public async Task<IActionResult> StudentList(int page = 1)
        {
            var data = await _unitOfWork.StudentInfo.GetAllByPageSizeAsync(page);
            return View(data);
        }*/

        public async Task<IActionResult> StudentList(string searchQuery, int page = 1)
        {
            // Retrieve paginated results
            var paginatedResult = await _unitOfWork.StudentInfo.GetAllByPageSizeAsync(page);

            // Filter students based on the search query
            if (!string.IsNullOrEmpty(searchQuery))
            {
                paginatedResult.Students = paginatedResult.Students
                    .Where(s => s.Name.Contains(searchQuery, StringComparison.OrdinalIgnoreCase))
                    .ToList();
            }

            // Prepare the view model
            var model = new PagerViewModel<StudentTable>
            {
                Students = paginatedResult.Students.ToList(),
                SearchQuery = searchQuery,
                Pager = new Pager(paginatedResult.Students.Count(), page, 12)
            };

            // Pass the view model to the view
            return View(paginatedResult);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

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
            var allStudents = await _unitOfWork.StudentInfo.GetAllAsync();

            if (!string.IsNullOrEmpty(searchQuery))
            {
                allStudents = allStudents
                    .Where(s => s.Name.Contains(searchQuery, StringComparison.OrdinalIgnoreCase))
                    .ToList();
            }

            var totalItems = allStudents.Count();

            var studentsToDisplay = allStudents
                .Skip((page - 1) * 12)
                .Take(12)
                .ToList();

            var model = new PagerViewModel<StudentTable>
            {
                Students = studentsToDisplay,
                SearchQuery = searchQuery,
                Pager = new Pager(totalItems, page, 12)
            };

            return View(model);
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

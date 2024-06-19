using Core.Entities;
using Core.Interface;
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

        public async Task<IActionResult> StudentList(int page = 1)
        {
            var data = await _unitOfWork.StudentInfo.GetAllByPageSizeAsync(page);
            return View(data);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

using Core.Entities;
using Core.Interface;
using Core.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace StudentCURD.Controllers
{
    public class StudentInfoController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public StudentInfoController(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }

        [HttpGet]
        public IActionResult StudentInfoAdd()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> StudentInfoAdd(AddStudentViewModel addStudentViewModel)
        {
            StudentTable student = new StudentTable();
            student.Id = Guid.NewGuid();
            student.Name = addStudentViewModel.Name;
            student.Gender = addStudentViewModel.Gender;
            student.DOB = addStudentViewModel.DOB;
            student.CreatedDate = addStudentViewModel.CreatedDate;
            student.ModificationDate = DateTime.Now;
            student.ClassId = addStudentViewModel.ClassId;

            if (_unitOfWork.StudentInfo != null)
            {
                await _unitOfWork.StudentInfo.AddAsync(student);
            }
            await _unitOfWork.CommitAsync();

            return RedirectToAction("StudentList", "Home");
        }

        [HttpGet]
        public async Task<IActionResult> Edit(Guid id)
        {
            if (_unitOfWork.StudentInfo != null)
            {
                StudentTable? student = await _unitOfWork.StudentInfo.GetByIdAsync(id);
                return View(student);
            }
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Edit(StudentTable viewModel)
        {
            if (_unitOfWork.StudentInfo != null)
            {
                StudentTable? student = await _unitOfWork.StudentInfo.GetByIdAsync(viewModel.Id);
                if (student is not null)
                {
                    student.Name = viewModel.Name;
                    student.Gender = viewModel.Gender;
                    student.DOB = viewModel.DOB;
                    student.ModificationDate = DateTime.Now;
                    student.ClassId = viewModel.ClassId;
                    await _unitOfWork.CommitAsync();
                }
                return RedirectToAction("StudentList", "Home");
            }
            return View();
        }

        [HttpPost("{id}")]
        public async Task<IActionResult> Delete(StudentTable viewModel)
        {
            if (_unitOfWork.StudentInfo != null)
            {
                var student = await _unitOfWork.StudentInfo.GetByIdAsync(viewModel.Id);
                if (student != null)
                {
                    await _unitOfWork.StudentInfo.DeleteAsync(student);
                    await _unitOfWork.CommitAsync();
                }
                return RedirectToAction("StudentList", "Home");
            }
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Detail(StudentTable data)
        {
            if (_unitOfWork.StudentInfo != null)
            {
                StudentTable? student = await _unitOfWork.StudentInfo.GetByIdAsync(data.Id);
                if(student != null)
                {
                    return View(student);
                }
            }
            return View();
        }
    }
}

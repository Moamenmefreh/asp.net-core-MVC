using Center.Models;
using Center.Repository;
using Microsoft.AspNetCore.Mvc;
using NuGet.Protocol.Core.Types;

namespace Center.Controllers
{
    public class StaffController : Controller
    {
        private readonly Services<Student> _IrepositoryStudent;
        private readonly Services<Teacher> _Irepositoryteacher;

        public StaffController(Services<Student> _Irepository, Services<Teacher> _Irepositoryteacher)
        {
            this._IrepositoryStudent = _Irepository;
            this._Irepositoryteacher = _Irepositoryteacher;
        }

        public IActionResult AllStudent()
        {
            IEnumerable<Student> all = _IrepositoryStudent.All();
            return View(all);
        }
        public IActionResult DeleteStudent(int id)
        {

            if (id == 0 || id != null)
            {
                var newitem = _IrepositoryStudent.FindAsync(id);
                TempData["Failed"] = "Sorry ! There IS Input Empty";
                return View(newitem);
            }
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> DeleteStudent(Student student)
        {
            if (student.Id == null || student.Name == null || student.Level == null)
            {
                TempData["Failed"] = "Sorry ! There IS Input Empty";
                return View();
            }
            _IrepositoryStudent.Delete(student.Id);
            TempData["message"] = "Student Deleted Successfully";
            return RedirectToAction("AllStudent");

        }

        public IActionResult AddStudent()
        {
            
            return View();
        }
        [HttpPost]
        public IActionResult AddStudent(Student student)
        {
            if (student.Id == null||student.Name==null||student.Level==null)
            {
                TempData["Failed"] = "Sorry ! There IS Input Empty";
                return View();
            }
            _IrepositoryStudent.Add(student);
            TempData["message"] = "Student Added Successfully";
            return RedirectToAction("AllStudent");
        }

        public async Task<IActionResult> Edit(int id)
        {
            var student = _IrepositoryStudent.FindAsync(id);


            return View(student);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(Student student)
        {
            if (student.Level > 3 || student.Level < 1 || student.Name == null)
            {
                TempData["Failed"] = "Sorry ! There IS Input Empty";
                return View();
            }
            _IrepositoryStudent.UpdateAsync(student);
            TempData["message"] = "Student Edited Successfully";
            return RedirectToAction("AllStudent");
        }

        /////////////////////////////////////////////////Teacher
        ///
        public IActionResult AllTeacher()
        {
            IEnumerable<Teacher> all = _Irepositoryteacher.All();
            return View(all);
        }
        public IActionResult AddTeacher()
        {

            return View();
        }
        [HttpPost]
        public IActionResult AddTeacher(Teacher teacher)
        {
            if (teacher.Name==null||teacher.Specialization==null)
            {
                TempData["Failed"] = "Sorry ! There IS Input Empty";
                return View()   ;
            }
            else
            {
                _Irepositoryteacher.Add(teacher);
                TempData["message"] = "Teacher Added Successfully";
                return RedirectToAction("AllTeacher");
            }
        }

        public IActionResult DeleteTeacher(int id)
        {
            if (id == 0 || id != null)
            {
                var newitem = _Irepositoryteacher.FindAsync(id);
                return View(newitem);
            }
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> DeleteTeacher(Teacher teacher)
        {
            _Irepositoryteacher.Delete(teacher.Id);
            TempData["message"] = "Teaher Deleted Successfully";
            return RedirectToAction("AllTeacher");

        }
        public async Task<IActionResult> EditTeacher(int id)
        {
            var teacher = _Irepositoryteacher.FindAsync(id);


            return View(teacher);
        }
        [HttpPost]
        public async Task<IActionResult> EditTeacher(Teacher teacher)
        {
            if (teacher.Name == null || teacher.Specialization==null)
            {
                TempData["Failed"] = "Sorry ! There IS Input Empty";
                return View();
            }
            _Irepositoryteacher.UpdateAsync(teacher);
            TempData["message"] = "Teacher Edited Successfully";
            return RedirectToAction("AllTeacher");
        }
    }
}
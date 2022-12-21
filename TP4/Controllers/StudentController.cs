using Microsoft.AspNetCore.Mvc;
using TP4.Models;
using TP4.Data;

namespace TP4.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            List<Student> result = StudentRepository.GetAllStudents();
            return View(result);
        }

        public IActionResult Courses()
        {
            List<string> result = StudentRepository.GetAllUniqueCourses();
            return View(result);
        }

        public IActionResult StudentsOfCourse(string course)
        {
            List<Student> result = StudentRepository.GetStudentsByCourse(course);
            return View(result);
        }
    }
}

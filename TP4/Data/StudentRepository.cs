using TP4.Models;

namespace TP4.Data
{
    public class StudentRepository
    {
        public static List<Student> GetAllStudents()
        {
            UniversityContext uniContext = UniversityContext.Instance;
            List<Student> res = uniContext.Student?.ToList() ?? new List<Student>();
            return res;
        }

        public static List<string> GetAllUniqueCourses()
        {
            List<Student> students = GetAllStudents();

            return students
                .Where((student) => student.course != null) // course won't be null
                .Select((student) => student.course ?? "") // ?? "" To get rid of VisualStudio warning
                .Distinct().ToList();
        }

        public static List<Student> GetStudentsByCourse(string course)
        {
            List<Student> students = GetAllStudents();

            return students
                .Where((student) => student.course == course)
                .ToList();
        }
    }
}

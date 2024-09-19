


using schoolmanagementsystem;

namespace SchoolManagementSystem
{
    public class SchoolBase
    {
        //Lärare 
        public List<Teacher> Teachers { get; set; } = new List<Teacher>();
        public List<Student> Students { get; set; } = new List<Student>();
        public List<Course> Courses { get; set; } = new List<Course>();


        public void ShowAllTeachers()
        {

            foreach (var teacher in Teachers)
            {
                teacher.DisplayInfo();
            }
        }

        public void ShowAllStudents()
        {
            foreach (var Student in Students)
            {
                Student.DisplayInfo();
            }


        }

        public void ShowAllCourses()
        {
            foreach (var Course in Courses)
            {
                Course.DisplayInfo();
            }


        }
    }

}

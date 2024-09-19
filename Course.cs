

namespace schoolmanagementsystem
{
    public class Course 
    {
        public string CourseName { get; set; }
        public string CourseId { get; set; }

        public void DisplayInfo()
        {
            Console.WriteLine($"Course: {CourseName}, CourseId: {CourseId}");
        }
    }

   

}


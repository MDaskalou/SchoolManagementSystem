using schoolmanagementsystem;
using SchoolManagementSystem;
using System.Security.Cryptography.X509Certificates;

namespace SchoolManagementSystem
{ 
   public class Program
  {
        static void Main(string[] args)
        {
            SchoolBase schoolbase = new SchoolBase();

            var mathCourse = new Course() { CourseName = "Mathematics", CourseId = "MATH01"};

            var religionCourse = new Course() { CourseName = "Religion", CourseId = "REL01"};


            schoolbase.Courses.Add(mathCourse);
            schoolbase.Courses.Add(religionCourse);



            // Skapa och lägg till lärare
            var teacher1 = new Teacher();


            teacher1.FullName = "Mikael Daskalou";
            teacher1.Age = 34;
            teacher1.Gender = "Male";
            teacher1.Subject = "Religion";
            teacher1.TeacherId = "101";
            schoolbase.Teachers.Add(teacher1);


            var teacher2 = new Teacher();
            teacher2.FullName = "Georgia Chalkia";
            teacher2.Age = 33;
            teacher2.Gender = "Female";
            teacher2.Subject = "Math";
            teacher2.TeacherId = "102";
            schoolbase.Teachers.Add(teacher2);



            var mathGrade = new Grade() { GradeValue = "A", CourseName = "Mathematic"};

            var religionGrade = new Grade() { GradeValue = "C" , CourseName = "Religion"};

            // Skapa och lägg till student
            var student1 = new Student();
            student1.FullName = "Tomas";
            student1.Age = 20;
            student1.Gender = "Male";
            student1.StudentId = 201;
            //student1.Course = "Mathematic";

           
            



            student1.AddGrade(mathGrade);// Lägg till betyg för matte
            student1.AddGrade(religionGrade);  // Lägg till betyg för matte
            schoolbase.Students.Add(student1);

            var student2 = new Student();
            student2.FullName = "Alexandra";
            student2.Age = 19;
            student2.Gender = "Female";
            student2.StudentId = 202;


            student2.AddGrade(religionGrade);  // Lägg till betyg för religion
            student2.AddGrade(mathGrade);  // Lägg till betyg för matte
            schoolbase.Students.Add(student2);


            Console.WriteLine("Courses");
            foreach (var course in schoolbase.Courses)
            {
                Console.WriteLine($"Course: {course.CourseName}, CourseId: {course.CourseId}");
            }

            Console.WriteLine("Students");
            foreach (var student in schoolbase.Students)
            {
                student.DisplayInfo();
            }

            Console.WriteLine("Teachers");
            foreach (var teacher in schoolbase.Teachers)
            {
                teacher.DisplayInfo();
            }
        }

  }    

}    
        
       
    
            



     
    
        
    


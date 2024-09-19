

using SchoolManagementSystem;
using System;
using System.Collections.Generic;

namespace schoolmanagementsystem
{
    public class Student : Person
    {
        public List<Grade> Grades { get; set; } = new List<Grade>();
        public List<Course> Courses { get; set; } = new List<Course>();
        public int StudentId { get; set; }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Student: {FullName}, Age: {Age}, Gender: {Gender}, StudentId {StudentId}");

            foreach (var grade in Grades)
            {
                Console.WriteLine($"Course: {grade.CourseName}, Grade: {grade.GradeValue}");
            }

            foreach (var course in Courses)
            {
                Console.WriteLine($"Course: {course.CourseName}, Course Id {course.CourseId}");
            }
        }
        public void AddGrade(Grade grade)
        {
            Grades.Add(grade);
        }
        public void AddCourse(Course course)
        {
            Courses.Add(course);
        }
    }

  

    public class Grade 
    {
        public string GradeValue { get; set; }
        public string CourseName { get; set; }

        public void DisplayInfo()
        {
            Console.WriteLine($"Grade: {GradeValue}, Course: {CourseName}");
        }



    }

}


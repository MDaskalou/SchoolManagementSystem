

namespace SchoolManagementSystem
{
    public class Teacher : Person
    {
        public string Subject { get; set; }
        public string TeacherId { get; set; }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Teacher: {FullName}, Age: {Age}, Gender: {Gender}, Subject: {Subject}, TeacherId {TeacherId}");

        }

    }


}



namespace SchoolManagementSystem
{
    public abstract class Person
    {
        public string FullName { get; set; }
       
        public int Age { get; set; }

        public string Gender { get; set; }


        public abstract void DisplayInfo();
       
    }
}

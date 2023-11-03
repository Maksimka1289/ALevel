

using ALevel_HW7.Interfaces;

namespace ALevel_HW7.Models
{
    public class Student : Person
    {
        private int GradeLevel { get; set; }
        public Student(string name, int age, int gradeLevel) : base(name, age)
        {
            GradeLevel = gradeLevel;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Grade Level: {GradeLevel}");
        }
    }
}

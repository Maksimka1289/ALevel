

using ALevel_HW7.Interfaces;

namespace ALevel_HW7.Models
{
    public class Teacher : Staff
    {
        private string Subject { get; set; }
        public Teacher(string name, int age, string role, string subject) : base(name, age, role)
        {
            Subject = subject;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Subject: {Subject}");
        }
    }
}

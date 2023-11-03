

using ALevel_HW7.Interfaces;

namespace ALevel_HW7.Models
{
    public class Staff : Person
    {
        private string Role {  get; set; }
        public Staff(string name, int age, string role) : base(name, age)
        {
            Role = role;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Role: {Role}");
        }
    }
}

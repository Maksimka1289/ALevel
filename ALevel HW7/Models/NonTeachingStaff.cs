

using ALevel_HW7.Interfaces;

namespace ALevel_HW7.Models
{
    public class NonTeachingStaff : Staff
    {
        private string Departament {  get; set; }
        public NonTeachingStaff(string name, int age, string role, string departament) : base(name, age, role)
        {
            Departament = departament;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Departament: {Departament}");
        }
    }
}

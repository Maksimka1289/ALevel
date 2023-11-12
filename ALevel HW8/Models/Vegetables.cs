using ALevel_HW8.Interfaces;

namespace ALevel_HW8.Models
{
    public class Vegetables : IVegetable
    {
        public string Name { get; set; }
        public int Calories { get; set; }

        public virtual string GetVegetableInfo()
        {
           return $"Name: {Name}, Calories: {Calories}";
        }
    }
}

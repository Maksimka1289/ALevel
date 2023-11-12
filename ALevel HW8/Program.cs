using ALevel_HW8.Models;
using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Vegetables[] vegetables = new Vegetables[]
        {
            new LeafyVegetable { Name = "Spinach", Calories = 7, Color = "Green", Texture = "Crunchy" },
            new RootVegetables { Name = "Carrot", Calories = 25, Shape = "Cylindrical" },
            new FruitVegetables { Name = "Tomato", Calories = 16, isSweet = false },
            new FruitVegetables { Name = "Apple", Calories = 13, isSweet = true}
        };

        Salad mySalad = new Salad(vegetables);
        Console.WriteLine("Total Calories: " + mySalad.CalculateTotalCalories());

        Vegetables[] sortedVegetables = mySalad.SortByCalories();
        Console.WriteLine("Sorted Vegetables:");
        foreach (var veg in sortedVegetables)
        {
            Console.WriteLine(veg.GetVegetableInfo());
        }

        Console.WriteLine("Finding by criteria (Is Sweet == false):");
        Vegetables[] foundVegetables = mySalad.FindByCriteria(veg => veg is FruitVegetables && !((FruitVegetables)veg).isSweet);
        foreach (var veg in foundVegetables)
        {
            Console.WriteLine(veg.GetVegetableInfo());
        }
    }
}

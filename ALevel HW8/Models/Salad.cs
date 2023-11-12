namespace ALevel_HW8.Models
{
    public class Salad
    {
        private Vegetables[] vegetables;

        public Salad(Vegetables[] vegetables)
        {
            this.vegetables = vegetables;
        }

        public int CalculateTotalCalories()
        {
            int totalCalories = 0;
            foreach (var vegetable in vegetables)
            {
                totalCalories += vegetable.Calories;
            }
            return totalCalories;
        }

        public Vegetables[] SortByCalories()
        {
            Array.Sort(vegetables, (x, y) => x.Calories.CompareTo(y.Calories));
            return vegetables;
        }

        public Vegetables[] FindByCriteria(Func<Vegetables, bool> criteria)
        {
            return vegetables.Where(criteria).ToArray();
        }
    }

}

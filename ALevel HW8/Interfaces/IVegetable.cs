namespace ALevel_HW8.Interfaces
{
    public interface IVegetable
    {
        public string Name { get; set; }
        public int Calories { get; set; }
        public string GetVegetableInfo();

    }
}

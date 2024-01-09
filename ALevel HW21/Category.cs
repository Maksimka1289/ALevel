namespace ALevel_HW21
{
    public class Category
    {
        public int Id { get; set; }
        public string Category_Name { get; set; }

        public List<Pet> Pets { get; set; }

        public List<Breed> Breeds { get; set; }
    }
}

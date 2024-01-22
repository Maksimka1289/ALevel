namespace ALevel_HW21
{
    public class Breed
    {
        public int Id { get; set; }
        public string Breed_Name { get; set; }
        public int Category_Id { get; set; }
        public Category Category { get; set; }
        public int? CategoryId { get; set; }
        public List<Pet> Pets { get; set; }
    }
}

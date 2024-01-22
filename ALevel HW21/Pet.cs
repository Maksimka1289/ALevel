namespace ALevel_HW21
{
    public class Pet
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Category_Id { get; set; }
        public int Breed_Id { get; set; }
        public float Age { get; set; }
        public int Location_Id { get; set; }
        public string Image_Url { get; set; }
        public string Description { get; set; }
        public Category Category { get; set; }
        public int? CategoryId { get; set; }
        public Breed Breed { get; set; }
        public int? BreedId { get; set; }
        public Location Location { get; set; }
        public int? LocationId { get; set; }
    }
}

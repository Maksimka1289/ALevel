namespace ALevel_HW8.Models
{
    public class LeafyVegetable : Vegetables
    {
        public string Color { get; set; }
        public string Texture { get; set; }

        public override string GetVegetableInfo()
        {
            return $"{base.GetVegetableInfo()}, Color: {Color}, Texture: {Texture}";
        }
    }

}

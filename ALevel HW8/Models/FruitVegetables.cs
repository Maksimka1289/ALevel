namespace ALevel_HW8.Models
{
    public class FruitVegetables : Vegetables
    {
        public bool isSweet {  get; set; }
        public override string GetVegetableInfo()
        {
            return $"{base.GetVegetableInfo()}, Is Sweet: {isSweet}";
        }
    }
}

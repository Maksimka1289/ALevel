namespace ALevel_HW8.Models
{
    public class RootVegetables : Vegetables
    {
        public string Shape { get; set; }

        public override string GetVegetableInfo()
        {
            return $"{base.GetVegetableInfo()}, Shape: {Shape}";
        }
    }

}

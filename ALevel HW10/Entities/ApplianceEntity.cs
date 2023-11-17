namespace ALevel_HW10.Entities
{
    public class ApplianceEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string isPlugIn { get; set; }
        public double powerConsumption { get; set; }
    }
}

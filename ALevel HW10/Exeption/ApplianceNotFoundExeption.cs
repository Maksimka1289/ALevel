namespace ALevel_HW10.Exeption
{
    public class ApplianceNotFoundExeption : Exception
    {
        public ApplianceNotFoundExeption(string message) : base(message) { }
        public ApplianceNotFoundExeption() { }
    }
}

using ALevel_HW10.Models;

namespace ALevel_HW10.Services.Abstractions
{
    public interface IApplianceService
    {
        Appliance GetAppliance(string name, string type, string isPlugIn);

        string AddApliance(Appliance appliance);
        string[] AddAppliances(List<Appliance> appliances);
    }
}

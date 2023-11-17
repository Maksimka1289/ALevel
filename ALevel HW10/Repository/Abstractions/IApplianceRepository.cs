using ALevel_HW10.Entities;
using ALevel_HW10.Models;

namespace ALevel_HW10.AppliancesRepository.Abstractions
{
    public interface IApplianceRepository
    {
        string AddAppliance(Appliance appliances);
        ApplianceEntity GetAppliance(string name, string type, string isPlugIn);
        string[] AddAppliances(List<Appliance> appliances);
    }
}

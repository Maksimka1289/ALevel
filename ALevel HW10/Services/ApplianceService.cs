using ALevel_HW10.AppliancesRepository.Abstractions;
using ALevel_HW10.Models;
using ALevel_HW10.Services.Abstractions;

namespace ALevel_HW10.Services
{
    public class ApplianceService : IApplianceService
    {
        private readonly IApplianceRepository _applianceRepository;


        public ApplianceService(IApplianceRepository applianceRepository)
        {
            _applianceRepository = applianceRepository;
        }
        public string AddApliance(Appliance appliance)
        {
            return _applianceRepository.AddAppliance(appliance);
        }

        public string[] AddAppliances(List<Appliance> appliances)
        {
            return _applianceRepository.AddAppliances(appliances);
        }

        public Appliance GetAppliance(string name, string type, string isPlugIn)
        {
            var appliance = _applianceRepository.GetAppliance(name, type, isPlugIn);

            return new Appliance()
            {
                Id = appliance.Id,
                Name = appliance.Name,
                Type = appliance.Type,
                isPlugIn = appliance.isPlugIn,
                powerConsumption = appliance.powerConsumption,
            };
        }
    }
}

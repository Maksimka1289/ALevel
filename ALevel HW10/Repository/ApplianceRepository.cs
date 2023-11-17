using ALevel_HW10.AppliancesRepository.Abstractions;
using ALevel_HW10.Entities;
using ALevel_HW10.Exeption;
using ALevel_HW10.Models;

namespace ALevel_HW10.AppliancesRepository
{
    public class ApplianceRepository : IApplianceRepository
    {
        private readonly List<ApplianceEntity> _mockStorage = new List<ApplianceEntity>();
        public string AddAppliance(Appliance appliances)
        {
            var applianceEntity = new ApplianceEntity()
            {
                Id = Guid.NewGuid(),
                Name = appliances.Name,
                Type = appliances.Type,
                isPlugIn = appliances.isPlugIn,
                powerConsumption = appliances.powerConsumption,
            };

            _mockStorage.Add(applianceEntity);

            return applianceEntity.Id.ToString();
        }
        public ApplianceEntity GetAppliance(string name, string type, string isPlugIn)
        {
            foreach (var item in _mockStorage)
            {
                if (item.Name == name || item.Type == type || item.isPlugIn == isPlugIn)
                {
                    return item;
                }
            }

            throw new ApplianceNotFoundExeption($"Appliances with criteria '{name}, {type}, {isPlugIn}' not found");
        }

        public string[] AddAppliances(List<Appliance> appliances)
        {
            var entityAppliances = new List<ApplianceEntity>();
            var ids = new List<string>();

            foreach (var appliance in appliances)
            {
                var entityAppliance = new ApplianceEntity()
                {
                    Id = Guid.NewGuid(),
                    Name = appliance.Name,
                    Type = appliance.Type,
                    isPlugIn = appliance.isPlugIn,
                    powerConsumption = appliance.powerConsumption,
                };

                ids.Add(entityAppliance.Id.ToString());
                entityAppliances.Add(entityAppliance);
                _mockStorage.Add(entityAppliance);
            }

            return ids.ToArray();
        }
    }
}

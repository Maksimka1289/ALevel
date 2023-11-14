using ALevel_HW10.Exeption;
using ALevel_HW10.Models;
using ALevel_HW10.Services.Abstractions;

namespace ALevel_HW10
{
    public class App
    {
        private readonly IApplianceService _applianceService;

        public App(IApplianceService applianceService)
        {
            _applianceService = applianceService;
        }

        public void Run()
        {
            try
            {
                var ids = _applianceService.AddAppliances(GetMockAppliance());
            }
            catch (ApplianceNotFoundExeption ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public List<Appliance> GetMockAppliance()
        {
            var appliances = new List<Appliance>();
            var selectedAppliances = new List<Appliance>();

            appliances.Add(new Appliance
            {
                Id = Guid.NewGuid(),
                Name = "Microwave",
                Type = "Kitchen",
                isPlugIn = "Yes",
                powerConsumption = 750.5,
            });

            appliances.Add(new Appliance
            {
                Id = Guid.NewGuid(),
                Name = "Blender",
                Type = "Kitchen",
                isPlugIn = "No",
                powerConsumption = 100.67,
            });

            appliances.Add(new Appliance
            {
                Id = Guid.NewGuid(),
                Name = "Dishwasher",
                Type = "Kitchen",
                isPlugIn = "Yes",
                powerConsumption = 1200.12,
            });

            appliances.Add(new Appliance
            {
                Id = Guid.NewGuid(),
                Name = "Dishwasher 2",
                Type = "Kitchen",
                isPlugIn = "Yes",
                powerConsumption = 1350.56,
            });

            appliances.Add(new Appliance
            {
                Id = Guid.NewGuid(),
                Name = "Multicooker",
                Type = "Kitchen",
                isPlugIn = "No",
                powerConsumption = 800.98,
            });

            appliances.Add(new Appliance
            {
                Id = Guid.NewGuid(),
                Name = "PK",
                Type = "Bedroom",
                isPlugIn = "No",
                powerConsumption = 200,
            });

            appliances.Add(new Appliance
            {
                Id = Guid.NewGuid(),
                Name = "PK Gaming",
                Type = "Bedroom",
                isPlugIn = "Yes",
                powerConsumption = 400,
            });

            appliances.Add(new Appliance
            {
                Id = Guid.NewGuid(),
                Name = "Iron",
                Type = "Bedroom",
                isPlugIn = "Yes",
                powerConsumption = 1400,
            });

            appliances.Add(new Appliance
            {
                Id = Guid.NewGuid(),
                Name = "Iron Super",
                Type = "Bedroom",
                isPlugIn = "No",
                powerConsumption = 1800,
            });

            appliances.Add(new Appliance
            {
                Id = Guid.NewGuid(),
                Name = "Lamp",
                Type = "Bedroom",
                isPlugIn = "Yes",
                powerConsumption = 250,
            });

            Console.WriteLine($"Selected appliance: ");
            for (int i = 0; i < appliances.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {appliances[i].Name}");
            }
            Console.WriteLine("\n");

            bool attempt = true;
            while (attempt)
            {
                Console.Write("Enter the parameter to sort by (Name/Type/Consumption/IsPlugIn) in alphabetical order or ascending order(if it is consumption or type 'skip' to skip this): ");
                string sortParameter = Console.ReadLine();
                bool isSortingSuccessful = false;

                switch (sortParameter.ToLower())
                {
                    case "name":
                        appliances = appliances.OrderBy(a => a.Name).ToList();
                        isSortingSuccessful = true;
                        attempt = false;
                        break;
                    case "type":
                        appliances = appliances.OrderBy(a => a.Type).ToList();
                        isSortingSuccessful = true;
                        attempt = false;
                        break;
                    case "consumption":
                        appliances = appliances.OrderBy(a => a.powerConsumption).ToList();
                        isSortingSuccessful = true;
                        attempt = false;
                        break;
                    case "isplugin":
                        appliances = appliances.OrderBy(a => a.isPlugIn).ToList();
                        isSortingSuccessful = true;
                        attempt = false;
                        break;
                    case "skip":
                        attempt = false;
                        break;
                    default:
                        Console.WriteLine("Invalid sort parameter. Sorting was not successful");
                        break;
                }

                if (isSortingSuccessful == true)
                {
                    Console.WriteLine("Sorted List:");
                    foreach (var appliance in appliances)
                    {
                        Console.WriteLine($"Name: {appliance.Name}, Type: {appliance.Type}, Power Consumption: {appliance.powerConsumption}, Is Plug In: {appliance.isPlugIn}");
                    }
                }
                Console.WriteLine("\n");
            }

            Console.WriteLine("Search for devices based on multiple parameters:");

            Console.Write("Enter the device name: ");
            string searchName = Console.ReadLine().ToLower();

            Console.Write("Enter the device type: ");
            string searchType = Console.ReadLine().ToLower();

            Console.Write("Enter the maximum power consumption: ");
            if (double.TryParse(Console.ReadLine(), out double maxPowerConsumption))
            {
                List<Appliance> searchResults = SearchDevices(appliances, searchName, searchType, maxPowerConsumption);

                Console.WriteLine("Search Results:");
                foreach (var result in searchResults)
                {
                    Console.WriteLine($"Name: {result.Name}, Type: {result.Type}, Power Consumption: {result.powerConsumption}");
                }
            }
            else
            {
                Console.WriteLine("Invalid input for multiple parameters.");
            }
            Console.WriteLine("\n");

            Console.Write("Enter the numbers of the appliances you want to select (comma-separated): ");

            string input = Console.ReadLine();

            string[] selectedIndices = input.Split(',');

            foreach (var index in selectedIndices)
            {
                if (int.TryParse(index, out int selectedIndeces) && selectedIndeces > 0 && selectedIndeces <= appliances.Count)
                {
                    selectedAppliances.Add(appliances[selectedIndeces - 1]);
                }
            }

            double totalPowerConsumption = CalculateTotalPowerConsumption(selectedAppliances);

            Console.WriteLine($"Total Power Consumption: {totalPowerConsumption} watts");
            return appliances;
        }
        public static List<Appliance> SearchDevices(List<Appliance> devices, string name, string type, double maxPowerConsumption)
        {
            return devices.Where(device =>
                (string.IsNullOrEmpty(name) || device.Name.Contains(name, StringComparison.OrdinalIgnoreCase)) &&
                (string.IsNullOrEmpty(type) || device.Type.Contains(type, StringComparison.OrdinalIgnoreCase)) &&
                (device.powerConsumption <= maxPowerConsumption)
            ).ToList();
        }
        public double CalculateTotalPowerConsumption(List<Appliance> selectedAppliances)
        {
            double totalPowerConsumption = 0.0;

            foreach (var appliance in selectedAppliances)
            {
                totalPowerConsumption += appliance.powerConsumption;
            }

            return totalPowerConsumption;
        }
    }
}

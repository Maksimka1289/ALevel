using ALevel_HW10;
using ALevel_HW10.AppliancesRepository;
using ALevel_HW10.AppliancesRepository.Abstractions;
using ALevel_HW10.Services;
using ALevel_HW10.Services.Abstractions;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

public class Program
{
    private static void Main(string[] args)
    {
        void ConfigureService(ServiceCollection serviceCollection, IConfiguration configuration)
        {
            serviceCollection
                .AddScoped<IApplianceRepository, ApplianceRepository>()
                .AddTransient<IApplianceService, ApplianceService>()
                .AddTransient<App>();
        }

        IConfiguration configuration = new ConfigurationBuilder()
            .Build();

        var serviceCollection = new ServiceCollection();
        ConfigureService(serviceCollection, configuration);
        var provider = serviceCollection.BuildServiceProvider();

        var app = provider.GetService<App>();
        app!.Run();
    }
}
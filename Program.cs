
using HW_DI_WeatherInfo.Clients;
using HW_DI_WeatherInfo.NotifyServices;
using HW_DI_WeatherInfo.ServiceCollection;
using Microsoft.Extensions.DependencyInjection;

//IServiceCollection services = new ServiceCollection();

//services.AddTransient<INotify, EmailNotification>();
//services.AddTransient<INotify, SMSNotification>();
//services.AddTransient<Airport>();
//services.AddTransient<User>();

//using var serviceProvider = services.BuildServiceProvider();
//IHasNotifyService shirimetivo = serviceProvider.GetRequiredService<Airport>();
//IHasNotifyService domodedovo = serviceProvider.GetRequiredService<Airport>();
//IHasNotifyService artem = serviceProvider.GetRequiredService<User>();


//var weatherManager = new WeatherManager();
//weatherManager.Register(domodedovo);
//weatherManager.Register(shirimetivo);
//weatherManager.Register(artem);
//await weatherManager.MonitoringTemperatures();

var serviceCollection = new ServiceCollection();
WeatherServiceCollection.AddWeatherServices(serviceCollection);
var serviceProvider = serviceCollection.BuildServiceProvider();
var weatherManager = serviceProvider.GetRequiredService<WeatherManager>();
IHasNotifyService shirimetivo = serviceProvider.GetRequiredService<Airport>();
IHasNotifyService domodedovo = serviceProvider.GetRequiredService<Airport>();
IHasNotifyService artem = serviceProvider.GetRequiredService<User>();
weatherManager.Register(domodedovo);
weatherManager.Register(shirimetivo);
weatherManager.Register(artem);
await weatherManager.MonitoringTemperatures();
Console.ReadLine();
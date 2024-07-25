using HW_DI_WeatherInfo.Clients;
using HW_DI_WeatherInfo.NotifyServices;
using HW_DI_WeatherInfo.NotifyServices.NotifyFactory;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_DI_WeatherInfo.ServiceCollection
{
    public class WeatherServiceCollection
    {
        public static IServiceCollection AddWeatherServices(IServiceCollection services)
        {

            services.AddSingleton<WeatherManager>();
            services.AddTransient<INotifyFactory, RandomNotifyFactory>();
            services.AddTransient<SMSNotification>();
            services.AddTransient<EmailNotification>();
            services.AddTransient<Airport>();
            services.AddTransient<User>();
            return services;
        }
    }
}

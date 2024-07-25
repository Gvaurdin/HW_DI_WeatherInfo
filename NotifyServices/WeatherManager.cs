using HW_DI_WeatherInfo.Clients;
using HW_DI_WeatherInfo.NotifyServices.NotifyFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_DI_WeatherInfo.NotifyServices
{
    public class WeatherManager
    {
        private List<IHasNotifyService> notifyServices = [];
        private readonly INotifyFactory? notifyFactory;
        private static int countRequest = 0; 

        public WeatherManager(INotifyFactory notifyFactory)
        {
            this.notifyFactory = notifyFactory;
        }

        public string Get()
        {
            Random random = new Random();
             return $"Temperature {random.Next(-20,30)}";
        }

        public async Task MonitoringTemperatures()
        {
            while(true)
            {
                string temperature = Get();
                if (temperature != null)
                {
                    Notify(temperature);
                }
                await Task.Delay(3000);
            }
        }

        public void Register(IHasNotifyService hasNotifyService)
        {
            notifyServices.Add(hasNotifyService);
        }

        public void Notify(string message)
        {
            countRequest++;
            Console.WriteLine($"Weather manager push request number : {countRequest}\n");
            Thread.Sleep(1000);
            foreach (var user in notifyServices)
            {
                user.Notify($"{user} : {message}");
                if (user is User u)
                {
                    u.UpdateNotificationMethod();
                }
                else if (user is Airport a)
                {
                    a.UpdateNotificationMethod();
                }
                Thread.Sleep(1000);
            }
            Console.WriteLine();
        }
    }
}

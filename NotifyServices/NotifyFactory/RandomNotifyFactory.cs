using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_DI_WeatherInfo.NotifyServices.NotifyFactory
{
    public class RandomNotifyFactory : INotifyFactory
    {
        private static readonly Random random = new Random();

        public INotify CreateRandomNotifycation()
        {
            // Здесь случайным образом выбирается реализация
            return random.Next(2) == 0
                ? new SMSNotification()
                : new EmailNotification();
        }
    }
}

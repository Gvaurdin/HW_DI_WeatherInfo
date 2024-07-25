using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_DI_WeatherInfo.NotifyServices
{
    public class EmailNotification : INotify
    {
        public void Notify(string message)
        {
            Console.WriteLine($"{message} Уведомление по почте");
        }
    }
}

using HW_DI_WeatherInfo.NotifyServices;
using HW_DI_WeatherInfo.NotifyServices.NotifyFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_DI_WeatherInfo.Clients
{
    public class User : IHasNotifyService
    {
        private readonly INotifyFactory notifyFactory;
        private INotify notifyService;

        public User(INotifyFactory notifyFactory)
        {
            this.notifyFactory = notifyFactory;
            this.notifyService = notifyFactory.CreateRandomNotifycation();
        }

        public void Notify(string message)
        {
            notifyService.Notify(message);
        }

        public void UpdateNotificationMethod()
        {
            notifyService = notifyFactory.CreateRandomNotifycation();
        }

        public override string ToString()
        {
            return $"Info for user";
        }
    }

}

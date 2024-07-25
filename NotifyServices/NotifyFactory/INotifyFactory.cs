using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_DI_WeatherInfo.NotifyServices.NotifyFactory
{
    public interface INotifyFactory
    {
        INotify CreateRandomNotifycation();
    }
}

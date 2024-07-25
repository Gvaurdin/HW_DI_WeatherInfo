using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_DI_WeatherInfo.NotifyServices
{
    public interface INotify
    {
        public void Notify(string message);
    }
}

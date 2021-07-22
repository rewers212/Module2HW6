using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW6
{
    public class HomeProvider : IHomeProvider
    {
        public HomeProvider()
        {
            ElectricalAppliance = new ElectricalAppliances[]
            {
                new SmartPhone
                {
                    Name = "Samsung Galaxy S20",
                    Power = 12,
                    OS = TypeOS.ANDROID,
                    SimCount = SimCounts.Two,
                    BatteryType = BatteryTypes.LiIon,
                    DisplayType = DisplayTypes.TFT,
                    Firm = "Samsung",
                    Price = 1000
                },
                new AnalogTelephone
                {
                    Name = "TX830",
                    Firm = "Panasonic",
                    BatteryType = BatteryTypes.NiCd,
                    Power = 2,
                    DisplayType = DisplayTypes.NON,
                    Price = 10,
                    Frequency = 800
                },
                new TV
                {
                    Name = "Bravis",
                    Diagonals = 30,
                    Display = DisplayTypes.IPS,
                    Power = 100,
                    Firm = "Bravis",
                    Price = 100
                },
                new Turntable
                {
                    Name
                }
            }
        }

        public ElectricalAppliances[] ElectricalAppliance => throw new NotImplementedException();
    }
}

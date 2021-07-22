using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW6
{
    public class HomeProvider : IHomeProvider
    {
        private ElectricalAppliances[] _ellapp;
        public HomeProvider()
        {
            _ellapp = new ElectricalAppliances[]
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
                    Name = "Sony kx100",
                    Firm = "Sony",
                    Portability = Portabilitys.Non,
                    Power = 15,
                    Price = 30,
                    TypeTurntable = TypeTurntables.Video
                },
                new Standart
                {
                    Name = "Nord",
                    Cooling = TypeCoolingSystems.Compressor,
                    Firm = "Nord",
                    Number = NumberOfCameras.Bicameral,
                    Power = 500,
                    Price = 1200
                },
                new SideBySide
                {
                    Name = "LG",
                    Firm = "LG",
                    IceMaker = IceMakerAvailability.Yes,
                    Power = 800,
                    Cooling = TypeCoolingSystems.Compressor,
                    Price = 3000
                },
                new Convection
                {
                    Name = "Samsung f600",
                    Firm = "Sumsung",
                    Power = 1000,
                    Price = 700,
                    Type = TypeOfManagements.Sensory
                },
                new ElectricGrill
                {
                    Name = "Gorenje",
                    Price = 800,
                    Power = 1100,
                    Type = TypeOfManagements.Mechanical,
                    Firm = "Gorenje"
                }
            };
        }

        public ElectricalAppliances[] ElectricalAppliance => _ellapp;
    }
}

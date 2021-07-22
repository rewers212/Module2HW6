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
                new 
            }
        }

        public ElectricalAppliances[] ElectricalAppliance { get; }
    }
}

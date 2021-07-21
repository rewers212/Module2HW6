using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW6
{
    public abstract class Telephone : Multimedia
    {
        public abstract BatteryTypes BatteryType { get; set; }
        public abstract DisplayTypes DisplayType { get; set; }
    }
}

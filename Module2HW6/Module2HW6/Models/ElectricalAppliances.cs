using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW6
{
    public abstract class ElectricalAppliances
    {
        public abstract string Price { get; set; }
        public abstract string Name { get; set; }
        public abstract string Firm { get; set; }
    }
}

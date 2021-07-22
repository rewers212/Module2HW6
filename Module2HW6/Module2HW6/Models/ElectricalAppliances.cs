using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW6
{
    public abstract class ElectricalAppliances
    {
        public double Price { get; set; }
        public string Name { get; set; }
        public string Firm { get; set; }
        public int Power { get; set; }
    }
}

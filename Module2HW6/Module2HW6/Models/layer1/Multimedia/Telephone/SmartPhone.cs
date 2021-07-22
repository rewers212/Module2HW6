using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW6
{
    public sealed class SmartPhone : Telephone
    {
        public TypeOS OS { get; set; }
        public SimCounts SimCount { get; set; }
    }
}

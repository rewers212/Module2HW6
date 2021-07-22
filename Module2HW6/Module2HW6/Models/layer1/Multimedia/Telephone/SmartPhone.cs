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
        public override BatteryTypes BatteryType { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override DisplayTypes DisplayType { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override string Price { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override string Firm { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}

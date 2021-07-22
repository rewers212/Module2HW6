using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW6
{
    public interface IHomeService
    {
        void Add(ElectricalAppliances item);
        void SortByPrice();
        int GetFullPower();
        public ElectricalAppliances[] GetAppliances();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW6
{
    public interface IHomeService
    {
        public void Add(ref ElectricalAppliances[] ea, int id);
    }
}

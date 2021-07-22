using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW6
{
    public class HomeService : IHomeService
    {
        private readonly int _count = 10;
        private ElectricalAppliances[] _electricalAppliances;
        public HomeService()
        {
            _electricalAppliances = new ElectricalAppliances[_count];
        }

        public void Add(ElectricalAppliances item)
        {
            for (var i = 0; i < _count; i++)
            {
                if (_electricalAppliances[i] == null)
                {
                    _electricalAppliances[i] = item;
                    return;
                }
            }
        }

        public ElectricalAppliances[] GetAppliances()
        {
            return _electricalAppliances;
        }

        public void SortByPrice()
        {
            Array.Sort(_electricalAppliances, new PriceComparer());
        }

        public int GetFullPower()
        {
            var sum = 0;
            foreach (var item in _electricalAppliances)
            {
                sum += item.Power;
            }

            return sum;
        }
    }
}

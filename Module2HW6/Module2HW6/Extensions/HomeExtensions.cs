using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW6.Extensions
{
    public static class HomeExtensions
    {
        public static ElectricalAppliances[] FindByName(this ElectricalAppliances[] ep, string name)
        {
            var result = new ElectricalAppliances[0];
            foreach (var item in ep)
            {
                if (item.Name == name)
                {
                    result = result.Add(item);
                }
            }

            return result;
        }

        public static ElectricalAppliances[] Add(this ElectricalAppliances[] eps, ElectricalAppliances ep)
        {
            var newLenght = eps.Length + 1;
            var result = new ElectricalAppliances[newLenght];
            for (var i = 0; i < eps.Length; i++)
            {
                result[i] = eps[i];
            }

            result[newLenght - 1] = ep;
            return result;
        }
    }
}

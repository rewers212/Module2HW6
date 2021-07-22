using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW6
{
    public class PriceComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            var firstFile = x as ElectricalAppliances;
            var secondFile = y as ElectricalAppliances;

            if (firstFile != null && secondFile != null)
            {
                if (firstFile.Price > secondFile.Price)
                {
                    return 1;
                }
                else if (firstFile.Price < secondFile.Price)
                {
                    return -1;
                }
                else
                {
                    return 0;
                }
            }
            else
            {
                throw new NotImplementedException();
            }
        }
    }
}

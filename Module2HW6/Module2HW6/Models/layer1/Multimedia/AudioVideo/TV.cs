using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW6
{
    public abstract class TV : AudioVideo
    {
        public DisplayTypes Display { get; set; }
        public int Diagonal { get; set; }
    }
}

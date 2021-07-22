using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW6
{
    public sealed class TV : AudioVideo
    {
        public DisplayTypes Display { get; set; }
        public int Diagonals { get; set; }
    }
}

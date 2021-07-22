using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW6
{
     public sealed class Turntable : AudioVideo
    {
        public TypeTurntables TypeTurntable { get; set; }
        public Portabilitys Portability { get; set; }
    }
}

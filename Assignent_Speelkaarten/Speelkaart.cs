using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignent_Speelkaarten
{
    enum Suite
    {
        Ruiten,
        Klaveren,
        Harten,
        Schoppen
    }
    internal class Speelkaart
    {
             

        public int Getal { get; set; }
        public Suite Suite { get; set; }
    }
}

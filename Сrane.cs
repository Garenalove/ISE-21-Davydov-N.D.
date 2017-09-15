using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabsAutmnWinter
{
    class Сrane
    {
        public bool water;

        public Сrane()
        {
            this.water = false;
        }

        public void waterOn()
        {
            this.water = true;
        }

        public void wash(RawProduct rawProduct)
        {
            rawProduct.isClean = true;
        }
    }
}

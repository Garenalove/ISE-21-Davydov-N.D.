using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabsAutmnWinter
{
    abstract class RawProduct : Product
    {
        public bool isClean;
        public bool isCut;

        public RawProduct(int weight):base(weight)
        {
            this.isClean = false;
            this.isCut = false;
        }
    }
}

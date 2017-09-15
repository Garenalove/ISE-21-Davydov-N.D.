using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabsAutmnWinter
{
    class Egg : Product
    {
        public bool isBroken;
    
        public Egg(int weight) : base(weight)
        {
            this.isBroken = false;
        }
    }
}

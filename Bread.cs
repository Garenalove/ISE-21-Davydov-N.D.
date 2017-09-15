using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabsAutmnWinter
{
    class Bread : Product
    {
        public bool withMilk;

        public Bread(int weight) : base(weight)
        {
            this.withMilk = false;
        }

        public void moisten(Milk milk)
        {
            if (milk.weight >= 50)
                this.withMilk = true;
        }
    }
}

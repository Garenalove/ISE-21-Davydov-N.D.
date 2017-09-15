using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabsAutmnWinter
{
    class Knife
    {
        public void cut(RawProduct rawProduct)
        {
            if (rawProduct.isClean)
                rawProduct.isCut = true;
        }

        public void brokeEgg(Egg egg)
        {
            egg.isBroken = true;
        }
    }
}

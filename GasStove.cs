using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabsAutmnWinter
{
    class GasStove
    {
        public bool turn;

        public GasStove()
        {
            this.turn = false;
        }

        public void turnOn()
        {
            this.turn = true;
        }

        public void warmUp(Pan pan)
        {
            if (turn)
                pan.temperature = 100;
        }
    }
}

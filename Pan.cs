using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabsAutmnWinter
{
    class Pan
    {
        public int temperature;
        private Oil oil
        {
            set
            {
                if (value.weight >= 30 && value.weight < 50)
                    this.oil = value;
            }
            get { return oil; }
        }
        private Forcemeat forcemeat
        {
            set
            {
                if (value.isCutlet)
                    this.forcemeat = value;
            }
            get { return forcemeat;}
        }

        public Pan()
        {
            this.temperature = 25;
        }
        
        public void addOil(Oil oil)
        {
            this.oil = oil;
        }

        public void addForcemeat(Forcemeat forcemeat)
        {
            this.forcemeat = forcemeat;
        }

        public Сutlet fry()
        {
            if (this.temperature >= 100 &&
                this.oil != null &&
                this.forcemeat != null)
                return new Сutlet();
            return null;

        }
        
        
    }
}

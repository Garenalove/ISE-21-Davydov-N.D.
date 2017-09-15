using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabsAutmnWinter
{
    class MeatGrinder
    {

        public bool turn;
        private Meat meat
        {
            set
            {
                if (value.weight > 500 && value.weight < 600 && value.isCut)
                    this.meat = value;
            }
            get { return meat; }
        }
        private Salt salt
        {
            set
            {
                if (value.weight >= 1 && value.weight < 2)
                    this.salt = value;
            }
            get { return salt; }
        }
        private Spice spice
        {
            set
            {
                if (value.weight >= 1 && value.weight < 2)
                    this.spice = value;
            }
            get { return spice; }
        }
        private Bread bread
        {
            set
            {
                if (value.withMilk && value.weight >= 80 && value.weight < 100)
                    this.bread = value;
            }
            get { return bread; }
        }

        private Egg egg
        {
            set
            {
                if (value.weight >= 1 && value.weight < 2)
                    this.egg = value;
            }
            get { return egg; }
        }

        public MeatGrinder()
        {
            this.turn = false;
        }

        public Forcemeat getForcemeat()
        {
            if (this.meat != null &&
                this.salt != null &&
                this.spice != null &&
                this.bread != null &&
                this.egg != null &&
                this.turn)
                return new Forcemeat();
            return null;
        }

        public void turnOn()
        {
            this.turn = true;
        }

        public void addMeat(Meat meat)
        {
            this.meat = meat;
        }

        public void addSpice(Spice spice)
        {
            this.spice = spice;
        }

        public void addBread(Bread bread)
        {
            this.bread = bread;
        }

        public void addEgg(Egg egg)
        {
            this.egg = egg;
        }

        public void addSalt(Salt salt)
        {
            this.salt = salt;
        }

    }
}

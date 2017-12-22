using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba2
{
    class UltaMegaBuffSuperMotorShip : MotorShip, IComparable<UltaMegaBuffSuperMotorShip>, IEquatable<MotorShip>
    {
        private bool pipe;
        private bool boats;
        private Color selfColor;

        public UltaMegaBuffSuperMotorShip(int maxSpeed, int maxCountPassenger, double weight, Color color,
            bool pipe, bool boats,Color selfColor) : base(maxSpeed, maxCountPassenger, weight, color)
        {
            this.pipe = pipe;
            this.boats = boats;
			this.selfColor = selfColor;
        }

        public UltaMegaBuffSuperMotorShip(string info) : base(info)
        {
            string[] strs = info.Split(';');
            if(strs.Length == 7)
            {
                pipe = Convert.ToBoolean(strs[4]);
                boats = Convert.ToBoolean(strs[5]);
                selfColor = Color.FromName(strs[6]);
            }
        }

        public void SetDopColor(Color color)
        {
            selfColor = color;
        }


        protected override void drawLightShip(Graphics g)
		{
			base.drawLightShip(g);
            PointF[] points = new PointF[5];
            Pen pen = new Pen(selfColor);
            if (pipe)
            {
                points[0] = new PointF(startX + 25, startY - 40);
                points[1] = new PointF(startX + 25, startY - 45);
                points[2] = new PointF(startX + 55, startY - 45);
                points[3] = new PointF(startX + 55, startY - 40);
                points[4] = new PointF(startX + 25, startY - 40);
                g.DrawPolygon(pen, points);
            }
            if (boats)
            {
                points = new PointF[7];
                points[0] = new PointF(startX+15, startY+7);
                points[1] = new PointF(startX + 45, startY+7);
                points[2] = new PointF(startX + 50, startY+2);
                points[3] = new PointF(startX + 65, startY+2);
                points[4] = new PointF(startX + 55, startY + 17);
                points[5] = new PointF(startX + 20, startY + 17);
                points[6] = new PointF(startX+15, startY+7);
                g.DrawPolygon(pen, points);
            }
        }

        public override string getInfo()
        {
            return MaxSpeed + ";" + MaxCountPassengers + ";" + Weight + ";" +
                ColorBody.Name + ";" + pipe + ";" + boats + ";" + selfColor.Name;
        }

        public int CompareTo(UltaMegaBuffSuperMotorShip other)
        {
            var res = (this is MotorShip).CompareTo(other is MotorShip);
            if(res != 0)
            {
                return res;
            }
            if(pipe != other.pipe)
            {
                return pipe.CompareTo(other.pipe);
            }
            if(boats != other.boats)
            {
                return boats.CompareTo(other.boats);
            }
            if(selfColor != other.selfColor)
            {
                return selfColor.Name.CompareTo(other.selfColor.Name);
            }
            return 0;
        }

        public bool Equals (UltaMegaBuffSuperMotorShip other)
        {
            var res = (this is MotorShip).Equals(other is MotorShip);
            if (!res)
            {
                return res;
            }
            if(pipe != other.pipe)
            {
                return false;
            }
            if(boats != other.boats)
            {
                return false;
            }
            if(selfColor != other.selfColor)
            {
                return false;
            }
            return true;
        }

        public override bool Equals(object obj)
        {
            if(obj == null)
            {
                return false;
            }
            UltaMegaBuffSuperMotorShip megaShipObj = obj as UltaMegaBuffSuperMotorShip;
            if(megaShipObj == null)
            {
                return false;
            }
            else
            {
                return Equals((UltaMegaBuffSuperMotorShip)megaShipObj);
            }
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

    }
}

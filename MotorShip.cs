using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba2
{
    public class MotorShip : Ship
    {
        public override int MaxSpeed
        {
            get { return base.MaxSpeed; }
            protected set
            {
                if (value > 0 && value < 300)
                {
                    base.MaxSpeed = value;		
                }
                else
                {
                    base.MaxSpeed = 150;
                }
            }
        }

        public override int MaxCountPassengers
        {
            get { return base.MaxCountPassengers; }
            protected set
            {
                if (value > 0 && value < 5)
                {
                    base.MaxCountPassengers = value;
                }
                else
                {
                    base.MaxCountPassengers = 4;
                }
            }
        }

        public override double Weight
        {
            get { return base.Weight; }
            protected set
            {
                if(value>500 && value < 1500)
                {
                    base.Weight = value;
                }
                else
                {
                    base.Weight = 1000;
                }
            }
        }

        public MotorShip(int maxSpeed,int maxCountPassenger,double weight,Color color)
        {
            this.MaxSpeed = maxSpeed;
            this.MaxCountPassengers = maxCountPassenger;
            this.ColorBody = color;
            this.Weight = weight;
            this.countPassengers = 0;
            Random r = new Random();
            this.startX = r.Next(10, 200);
            this.startY = r.Next(10, 200);
        }

        public override void moveShip(Graphics g)
        {
            startX +=
                (MaxSpeed * 50 / (float)Weight) /
                    (countPassengers == 0 ? 1 : countPassengers);
            drawShip(g);
        }

        public override void drawShip(Graphics g)
        {
			drawLightShip(g);
        }

        protected virtual void drawLightShip(Graphics g)
        {
            Pen pen = new Pen(ColorBody);
            Pen pen2 = new Pen(Color.Black);
            PointF[] points = new PointF[7];
            points[0] = new PointF(startX, startY);
            points[1] = new PointF(startX + 60, startY);
            points[2] = new PointF(startX + 70, startY - 10);
            points[3] = new PointF(startX + 100, startY - 10);
            points[4] = new PointF(startX + 80, startY + 20);
            points[5] = new PointF(startX + 10, startY + 20);
            points[6] = new PointF(startX, startY);
            g.DrawPolygon(pen2, points);
            points = new PointF[15];
            points[0] = new PointF(startX + 10, startY);
            points[1] = new PointF(startX + 10, startY - 20);
            points[2] = new PointF(startX + 20, startY - 20);
            points[3] = new PointF(startX + 20, startY - 30);
            points[4] = new PointF(startX + 30, startY - 30);
            points[5] = new PointF(startX + 30, startY - 50);
            points[6] = new PointF(startX + 50, startY - 50);
            points[7] = new PointF(startX + 50, startY - 30);
            points[8] = new PointF(startX + 70, startY - 30);
            points[9] = new PointF(startX + 70, startY - 20);
            points[10] = new PointF(startX + 80, startY - 20);
            points[11] = new PointF(startX + 80, startY - 10);
            points[12] = new PointF(startX + 70, startY - 10);
            points[13] = new PointF(startX + 60, startY);
            points[14] = new PointF(startX + 10, startY);
            g.DrawPolygon(pen2, points);
            g.DrawLine(pen2, startX + 10, startY - 20, startX + 70, startY - 20);
            g.DrawLine(pen2, startX + 20, startY - 30, startX + 60, startY - 30);
            g.DrawLine(pen2, startX + 30, startY - 45, startX + 50, startY - 45);
            g.DrawRectangle(pen, startX + 20, startY - 15, 10, 10);
            g.DrawRectangle(pen, startX + 30, startY - 15, 10, 10);
            g.DrawRectangle(pen, startX + 70, startY, 10, 10);
            for(int i = 0; i < 5; i++)
            {
                g.DrawEllipse(pen, startX + 22 + (10 * i), startY - 27, 5, 5);
            }

        }
    }
}

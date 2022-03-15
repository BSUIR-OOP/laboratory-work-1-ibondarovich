using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Point
    { 
        protected double x;
        protected double y;


        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

      /*  public double X
        {
            get
            { 
                return x;
            }
            set
            {
                x = value;
            }
        }

        public double Y
        {
            get
            {
                return y;
            }
            set
            {
                y = value;
            }
        }*/

        /*public virtual void SetLocation(double x, double y)
        {
            this.x = x;
            this.y = y;
        }*/

        public virtual void ShowFigure()
        {
            Console.WriteLine("Точка с координатами ({0};{1})",x,y);
        }
    }
}

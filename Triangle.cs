using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Triangle: Point
    {

        private double x1;
        private double y1;
        private double x2;
        private double y2;


        public Triangle(double x0, double y0, double x1, double y1, double x2, double y2):base(x0,y0)
        {
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x2;
            this.y2 = y2;
        }

        public override void ShowFigure()
        {
            Console.WriteLine("Треугольник с веришинами в точках ({0};{1}), ({2};{3}) и ({4};{5})",x,y,x1,y1,x2,y2);
        }
    }
}

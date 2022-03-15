using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Rectangle: Point
    {
        private double width;
        private double height;

        public Rectangle(double x, double y, double width, double height):base(x,y)
        {
            this.width = width;
            this.height = height;
        }

        public override void ShowFigure()
        {
            Console.WriteLine("Прямоугольник с верхней левой вершиной в точке ({0};{1}), длиной {2} и шириной {3}",x,y,height,width);
        }
    }
}

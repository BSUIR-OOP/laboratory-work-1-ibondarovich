using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Line: Point
    {

        private double width;
        private double height;
        
        public Line(double x, double y, double width, double height):base(x,y)
        {
            this.width = x + width;
            this.height = y + height;
        }
        public override void ShowFigure()
        {
            Console.WriteLine("Отрезок с координатами ({0},{1}) и ({2},{3})",x,y,width,height);
        }


    }
}

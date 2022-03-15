using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Ellipse:Point
    {
        protected double semi_axel1;
        protected double semi_axel2;

        public Ellipse(double x, double y, double semi_axel1, double semi_axel2) :base(x,y)
        {
            this.semi_axel1 = semi_axel1;
            this.semi_axel2 = semi_axel2;
        }

        public override void ShowFigure()
        {
            Console.WriteLine("Эллипс с центром в точке ({0};{1} и полуосями {2} и {3})",x,y,semi_axel1,semi_axel2);
        }
    }
}

using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            FigureList figList = new FigureList(new Point[]
            {
                new Point(20, 30),
                new Line(20, 30, 50, 10),
                new Ellipse(0,0,5,3),
                new Circle(6,10,20),
                new Rectangle(3,4,20,100),
                new Triangle(10,20,30,40,50,60)
            });

            figList.DrawFigures();
        }





    }
   
}

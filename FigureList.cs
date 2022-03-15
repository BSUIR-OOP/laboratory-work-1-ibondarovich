using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class FigureList
    {
        private List<Point> figureList;

        public FigureList(Point[] fig)
        {
            figureList = new List<Point>();
            figureList.AddRange(fig);
         
        }
        public void DrawFigures()
        {
            foreach (var figure in figureList)
            {
                figure.ShowFigure();
            }
        }



    }
}

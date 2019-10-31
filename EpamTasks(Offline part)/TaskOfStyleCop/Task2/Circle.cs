using LibraryOfInterfacesAndClasses.AdditionalInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskOfStyleCop.Task2
{
    public class Circle
    {


        public Point Center { get; set; }
        public double Radius { get; set; }

        public Circle()
        {
            Center = new Point(0, 0);
            Radius = 0;
        }

        public Circle(Point center, double radius)
        {
            Center = center;
            Radius = radius;
        }

        public void OutputCircle(IWriteReadable WriteReadOfData)
        {
            WriteReadOfData.Write($"Center of the circle ({Center.X}, {Center.Y}), Radius: {Radius}");
        }
    }
}

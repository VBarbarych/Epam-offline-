using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskOfStruct.Task2
{
    struct Rectangle : ISize, ICoordinates
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public int X { get; set; }
        public int Y { get; set; }

        public Rectangle(double width, double height, int x, int y)
        {
            this.Width = width;
            this.Height = height;
            this.X = x;
            this.Y = y;
        }

        public double Perimeter()
        {
            return 2 * Width + 2 * Height;
        }
    }
}

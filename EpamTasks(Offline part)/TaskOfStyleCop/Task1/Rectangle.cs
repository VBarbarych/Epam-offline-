using LibraryOfInterfacesAndClasses.AdditionalInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskOfStyleCop
{
    public class Rectangle
    {
        public Point UpperLeft { get; set; }
        public Point LowerRight { get; set; }
        private Point LowerLeft { get; set; }
        private Point UpperRight { get; set; }

        
        public Rectangle()
        {
            UpperLeft = new Point(0, 0);
            LowerRight = new Point(0, 0);
        }

        public Rectangle(Point upperLeft, Point lowerRight)
        {
            UpperLeft = upperLeft;
            LowerRight = lowerRight;
        }

        public Point LowerLeftPoint
        {
            get => new Point(UpperLeft.X, LowerRight.Y);
            set => LowerLeft = value;
        }

        public Point UpperRightPoint
        {
            get => new Point(LowerRight.X, UpperLeft.Y);
            set => UpperRight = value;
        }


        public void OutputPoints(IWriteReadable WriteReadOfData)
        {

            WriteReadOfData.Write($"UpperLeft({UpperLeft.X}, {UpperLeft.Y}), UpperRight({UpperRightPoint.X}, {UpperRightPoint.Y})");
            WriteReadOfData.Write($"LowerLeft({LowerLeftPoint.X}, {LowerLeftPoint.Y}), LowerRight({LowerRight.X}, {LowerRight.Y})");
        }

    }
}

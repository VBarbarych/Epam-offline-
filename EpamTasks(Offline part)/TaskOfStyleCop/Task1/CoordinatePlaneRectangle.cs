using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskOfStyleCop.Task2;

namespace TaskOfStyleCop
{
    public class CoordinatePlaneRectangle
    {
        private Rectangle FirstRectangle { get; set; }

        private Rectangle SecondRectangle { get; set; }

        public CoordinatePlaneRectangle(Rectangle firstRectangle, Rectangle secondRectangle)
        {
            FirstRectangle = firstRectangle;
            SecondRectangle = secondRectangle;
        }

        public void MoveSelectedFigure(Rectangle selectedRectangle, Direction direction, int distance)
        {
            if(direction == Direction.Left)
            {
                selectedRectangle.UpperLeft = new Point(selectedRectangle.UpperLeft.X - distance, selectedRectangle.UpperLeft.Y);
                selectedRectangle.LowerRight = new Point(selectedRectangle.LowerRight.X - distance, selectedRectangle.LowerRight.Y);
            }
            else if(direction == Direction.Right)
            {
                selectedRectangle.UpperLeft = new Point(selectedRectangle.UpperLeft.X + distance, selectedRectangle.UpperLeft.Y);
                selectedRectangle.LowerRight = new Point(selectedRectangle.LowerRight.X + distance, selectedRectangle.LowerRight.Y);
            }
            else if(direction == Direction.Up)
            {
                selectedRectangle.UpperLeft = new Point(selectedRectangle.UpperLeft.X, selectedRectangle.UpperLeft.Y - distance);
                selectedRectangle.LowerRight = new Point(selectedRectangle.LowerRight.X, selectedRectangle.LowerRight.Y - distance);
            }
            else if(direction == Direction.Down)
            {
                selectedRectangle.UpperLeft = new Point(selectedRectangle.UpperLeft.X, selectedRectangle.UpperLeft.Y + distance);
                selectedRectangle.LowerRight = new Point(selectedRectangle.LowerRight.X, selectedRectangle.LowerRight.Y + distance);
            }
        }

        public void ChangeFigureSize(Rectangle selectedRectangle, Size size, int scale)
        {
            if (size == Size.Enlarge)
            {
                selectedRectangle.UpperLeft = new Point(selectedRectangle.UpperLeft.X - scale, selectedRectangle.UpperLeft.Y + scale);
                selectedRectangle.LowerRight = new Point(selectedRectangle.LowerRight.X + scale, selectedRectangle.LowerRight.Y - scale);
            }
            else if (size == Size.Reduce)
            {
                selectedRectangle.UpperLeft = new Point(selectedRectangle.UpperLeft.X + scale, selectedRectangle.UpperLeft.Y - scale);
                selectedRectangle.LowerRight = new Point(selectedRectangle.LowerRight.X - scale, selectedRectangle.LowerRight.Y + scale);
            }
        }

        public Rectangle ConstructionRectangleContainingTwoGiven()
        {
            int x1 = FirstRectangle.UpperLeft.X;
            int x2 = SecondRectangle.UpperLeft.X;
            int y1 = FirstRectangle.UpperLeft.Y;
            int y2 = SecondRectangle.UpperLeft.Y;
            int x3 = FirstRectangle.LowerRight.X;
            int x4 = SecondRectangle.LowerRight.X;
            int y3 = FirstRectangle.LowerRight.Y;
            int y4 = SecondRectangle.LowerRight.Y;

            return new Rectangle(new Point(Math.Min(x1, x2), Math.Max(y1, y2)), new Point(Math.Max(x3, x4), Math.Min(y3, y4)));
        }

        public Rectangle ConstructionRectangleUnionTwoGiven()
        {
            int x1 = FirstRectangle.UpperLeft.X;
            int x2 = SecondRectangle.UpperLeft.X;
            int y1 = FirstRectangle.UpperLeft.Y;
            int y2 = SecondRectangle.UpperLeft.Y;
            int x3 = FirstRectangle.LowerRight.X;
            int x4 = SecondRectangle.LowerRight.X;
            int y3 = FirstRectangle.LowerRight.Y;
            int y4 = SecondRectangle.LowerRight.Y;

            return new Rectangle(new Point(Math.Max(x1, x2), Math.Min(y1, y2)), new Point(Math.Min(x3, x4), Math.Max(y3, y4)));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskOfStyleCop.Task2
{
    class CoordinatePlaneCircle
    {
        private Circle FirstCircle { get; set; }
        private Circle SecondCircle { get; set; }

       
        public CoordinatePlaneCircle(Circle firstCircle, Circle secondCircle)
        {
            FirstCircle = firstCircle;
            SecondCircle = secondCircle;
        }

        
        public void MoveSelectedFigure(Circle selectedCircle, Direction direction, int distance)
        {
            if (direction == Direction.Left)
            {
                selectedCircle.Center = new Point(selectedCircle.Center.X - distance, selectedCircle.Center.Y);
            }
            else if (direction == Direction.Right)
            {
                selectedCircle.Center = new Point(selectedCircle.Center.X + distance, selectedCircle.Center.Y);
            }
            else if (direction == Direction.Up)
            {
                selectedCircle.Center = new Point(selectedCircle.Center.X, selectedCircle.Center.Y - distance);
            }
            else if (direction == Direction.Down)
            {
                selectedCircle.Center = new Point(selectedCircle.Center.X, selectedCircle.Center.Y + distance);
            }
        }

        public void ChangeFigureSize(Circle selectedCircle, Size size, int scale)
        {
            if (size == Size.Enlarge)
            {
                selectedCircle.Radius += scale;
            }
            else if (size == Size.Reduce)
            {
                selectedCircle.Radius -= scale;
            }
        }
    }
}

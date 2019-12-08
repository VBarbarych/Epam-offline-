using LibraryOfInterfacesAndClasses.AdditionalInterfaces;

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

        public void OutputCircle(IWriteReadable writeReadOfData)
        {
            writeReadOfData.Write($"Center of the circle ({Center.X}, {Center.Y}), Radius: {Radius}");
        }
    }
}

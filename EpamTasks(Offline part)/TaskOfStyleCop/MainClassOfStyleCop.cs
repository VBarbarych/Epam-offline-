using LibraryOfInterfacesAndClasses.AdditionalInterfaces;
using TaskOfStyleCop.Task2;

namespace TaskOfStyleCop
{
    public class MainClassOfStyleCop : IRunable
    {
        private IWriteReadable writeReadOfData;

        public MainClassOfStyleCop(IWriteReadable writeReadOfData)
        {
            this.writeReadOfData = writeReadOfData;
        }

        public void ImplementTask1()
        {
            Rectangle firstRectangle = new Rectangle(new Point(1, 6), new Point(4, 2));
            Rectangle secondRectangle = new Rectangle(new Point(3, 5), new Point(7, 1));

            CoordinatePlaneRectangle CPRectangle = new CoordinatePlaneRectangle(firstRectangle, secondRectangle);

            Rectangle constructionRectangleContainingTwoGiven;
            Rectangle constructionRectangleUnionTwoGiven;

            writeReadOfData.Write("\n\n=========Task of StyleCop=======\n");
            writeReadOfData.Write("The starting points of the rectangle: ");
            firstRectangle.OutputPoints(writeReadOfData);
            secondRectangle.OutputPoints(writeReadOfData);

            writeReadOfData.Write("\nRectangle that contain two another rectangles: ");
            constructionRectangleContainingTwoGiven = CPRectangle.ConstructionRectangleContainingTwoGiven();
            constructionRectangleContainingTwoGiven.OutputPoints(writeReadOfData);

            writeReadOfData.Write("\nRectangle that is union of two another rectangles: ");
            constructionRectangleUnionTwoGiven = CPRectangle.ConstructionRectangleUnionTwoGiven();
            constructionRectangleUnionTwoGiven.OutputPoints(writeReadOfData);

            CPRectangle.MoveSelectedFigure(firstRectangle, Direction.Left, 1);
            CPRectangle.MoveSelectedFigure(secondRectangle, Direction.Right, 2);
            writeReadOfData.Write("\nFirst rectangle after move on the left on 1: ");
            firstRectangle.OutputPoints(writeReadOfData);
            writeReadOfData.Write("\nSecond rectangle after move on the right on 2: ");
            secondRectangle.OutputPoints(writeReadOfData);

            writeReadOfData.Write("\nChange size of rectangle: ");
            CPRectangle.ChangeFigureSize(firstRectangle, Size.Enlarge, 2);
            firstRectangle.OutputPoints(writeReadOfData);
        }

        public void ImplementTask2()
        {
            Circle firstCircle = new Circle(new Point(3, 3), 2);
            Circle secondCircle = new Circle(new Point(1, 1), 1);

            CoordinatePlaneCircle CPCircle = new CoordinatePlaneCircle(firstCircle, secondCircle);

            writeReadOfData.Write("\nThe starting data of circles: ");
            firstCircle.OutputCircle(writeReadOfData);
            secondCircle.OutputCircle(writeReadOfData);

            CPCircle.MoveSelectedFigure(firstCircle, Direction.Left, 1);
            CPCircle.MoveSelectedFigure(secondCircle, Direction.Right, 2);
            writeReadOfData.Write("\nFirst circle after move on the left on 1: ");
            firstCircle.OutputCircle(writeReadOfData);
            writeReadOfData.Write("\nSecond circle after move on the right on 2: ");
            secondCircle.OutputCircle(writeReadOfData);

            writeReadOfData.Write("\nChange size of the first circle: ");
            CPCircle.ChangeFigureSize(firstCircle, Size.Enlarge, 2);
            firstCircle.OutputCircle(writeReadOfData);
        }

        public void Run()
        {
            ImplementTask1();
            ImplementTask2();
        }
    }
}

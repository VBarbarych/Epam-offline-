using LibraryOfInterfacesAndClasses.AdditionalInterfaces;
using TaskOfStyleCop.Task2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TaskOfStyleCop
{
    public class MainClassOfStyleCop : IRunable
    {
        public IWriteReadable WriteReadOfData;

        public MainClassOfStyleCop(IWriteReadable writeReadOfData)
        {
            this.WriteReadOfData = writeReadOfData;
        }

        public void ImplementTask1()
        {
            Rectangle firstRectangle = new Rectangle(new Point(1, 6), new Point(4, 2));
            Rectangle secondRectangle = new Rectangle(new Point(3, 5), new Point(7, 1));
            

            CoordinatePlaneRectangle CPRectangle = new CoordinatePlaneRectangle(firstRectangle, secondRectangle);

            Rectangle constructionRectangleContainingTwoGiven;
            Rectangle constructionRectangleUnionTwoGiven;

            WriteReadOfData.Write("\n\n=========Task of StyleCop=======\n");
            WriteReadOfData.Write("The starting points of the rectangle: ");
            firstRectangle.OutputPoints(WriteReadOfData);
            secondRectangle.OutputPoints(WriteReadOfData);

            WriteReadOfData.Write("\nRectangle that contain two another rectangles: ");
            constructionRectangleContainingTwoGiven = CPRectangle.ConstructionRectangleContainingTwoGiven();
            constructionRectangleContainingTwoGiven.OutputPoints(WriteReadOfData);

            WriteReadOfData.Write("\nRectangle that is union of two another rectangles: ");
            constructionRectangleUnionTwoGiven = CPRectangle.ConstructionRectangleUnionTwoGiven();
            constructionRectangleUnionTwoGiven.OutputPoints(WriteReadOfData);

            CPRectangle.MoveSelectedFigure(firstRectangle, Direction.Left, 1);
            CPRectangle.MoveSelectedFigure(secondRectangle, Direction.Right, 2);
            WriteReadOfData.Write("\nFirst rectangle after move on the left on 1: ");
            firstRectangle.OutputPoints(WriteReadOfData);
            WriteReadOfData.Write("\nSecond rectangle after move on the right on 2: ");
            secondRectangle.OutputPoints(WriteReadOfData);

            WriteReadOfData.Write("\nChange size of rectangle: ");
            CPRectangle.ChangeFigureSize(firstRectangle, Size.Enlarge, 2);
            firstRectangle.OutputPoints(WriteReadOfData);


            

        }

        public void ImplementTask2()
        {
            Circle firstCircle = new Circle(new Point(3, 3), 2);
            Circle secondCircle = new Circle(new Point(1, 1), 1);

            CoordinatePlaneCircle CPCircle = new CoordinatePlaneCircle(firstCircle, secondCircle);

            WriteReadOfData.Write("\nThe starting data of circles: ");
            firstCircle.OutputCircle(WriteReadOfData);
            secondCircle.OutputCircle(WriteReadOfData);



            CPCircle.MoveSelectedFigure(firstCircle, Direction.Left, 1);
            CPCircle.MoveSelectedFigure(secondCircle, Direction.Right, 2);
            WriteReadOfData.Write("\nFirst circle after move on the left on 1: ");
            firstCircle.OutputCircle(WriteReadOfData);
            WriteReadOfData.Write("\nSecond circle after move on the right on 2: ");
            secondCircle.OutputCircle(WriteReadOfData);

            WriteReadOfData.Write("\nChange size of the first circle: ");
            CPCircle.ChangeFigureSize(firstCircle, Size.Enlarge, 2);
            firstCircle.OutputCircle(WriteReadOfData);
            
        }

        public void Run()
        {
            ImplementTask1();
            ImplementTask2();
        }
    }
}

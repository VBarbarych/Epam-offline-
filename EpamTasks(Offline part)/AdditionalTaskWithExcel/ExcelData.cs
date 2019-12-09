using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryOfInterfacesAndClasses.AdditionalInterfaces;
using Logger;
using Microsoft.Office.Interop.Excel;

namespace TaskWithExcel
{
    public class ExcelData
    {
        private IWriteReadable writeReadOfData;
        private ILogging logger;

        public HashSet<string> Read(string path, string column)
        {
            Application excelApp = new Application();

            // excelApp.Visible = true;
            excelApp.Workbooks.Open(
                path,
                Type.Missing, true, Type.Missing, Type.Missing,
                Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                Type.Missing, Type.Missing);

            int row = 1;
            int numberOfBooks = 1;
            int numberOfSheet = 1;
            Worksheet currentSheet = (Worksheet)excelApp.Workbooks[numberOfBooks].Worksheets[numberOfSheet];
            HashSet<string> tempList = new HashSet<string>();

            while (currentSheet.get_Range(column + row).Value2 != null)
            {
                Range cell = currentSheet.get_Range(column + row);
                tempList.Add(cell != null ? cell.Value2.ToString() : string.Empty);

                row++;
            }

            excelApp.Quit();

            return tempList;
        }

        public void Output(IWriteReadable writeReadOfData, HashSet<string> uniqueElementsSecondFirstColumn, HashSet<string> uniqueElementsFromSecondColumn)
        {
            writeReadOfData.Write($"Unique elements from first column: ");
            foreach (string element in uniqueElementsSecondFirstColumn)
            {
                writeReadOfData.Write(element);
            }

            writeReadOfData.Write($"\nUnique elements from second column: ");
            foreach (string element in uniqueElementsFromSecondColumn)
            {
                writeReadOfData.Write(element);
            }
        }
    }
}

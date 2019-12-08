using System;
using System.Collections.Generic;
using LibraryOfInterfacesAndClasses.AdditionalInterfaces;
using Logger;

namespace TaskOfEnum.Task2
{
    public class Colors : ISort, IColorWriter
    {
        private List<int> colors;
        private IWriteReadable writeReadOfData;
        private readonly ILogging logger;

        public Colors(IWriteReadable writeReadOfData, ILogging logger)
        {
            this.writeReadOfData = writeReadOfData;
            this.logger = logger;
        }

        public void SortEnum()
        {
            colors = new List<int>();

            var color = Color.Green;
            colors = color.SortEnum();
        }

        public void OutputColors()
        {
            foreach (int i in colors)
            {
                writeReadOfData.Write($"{Enum.GetName(typeof(Color), i)} = {i}");
            }
        }
    }
}

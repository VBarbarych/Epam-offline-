using LibraryOfInterfacesAndClasses.AdditionalInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskOfThreading
{
    public class MainClassOfThreading : IRunable
    {
        private IWriteReadable writeReadOfData;

        public MainClassOfThreading(IWriteReadable writeReadOfData)
        {
            this.writeReadOfData = writeReadOfData;
        }

        public void Run()
        {
            ImplementTask();
        }

        private void ImplementTask()
        {
            MatrixThreading matrix = new MatrixThreading(writeReadOfData);
            matrix.RandomMatrix();
            matrix.AsyncSumOfMatrix();

        }
    }
}

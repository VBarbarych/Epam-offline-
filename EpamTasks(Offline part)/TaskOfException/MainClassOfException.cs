using System;
using LibraryOfInterfacesAndClasses.AdditionalClasses;
using LibraryOfInterfacesAndClasses.AdditionalInterfaces;
using Logger;
using TaskOfException.Task1;
using TaskOfException.Task2;

namespace TaskOfException
{
    public class MainClassOfException : IRunable
    {
        private IWriteReadable writeReadOfData;
        private ILogging logger;

        public MainClassOfException(IWriteReadable writeReadOfData, ILogging logger)
        {
            this.writeReadOfData = writeReadOfData;
            this.logger = logger;
        }

        public void Run()
        {
            // ImplementOfTask1();
            ImplementOfTask2();
            ImplementOfTask4();
            // ImplementOfTask5();
        }

        private void ImplementOfTask1()
        {
            StackOverflowExceptionTask.Factorial(1);
        }

        private void ImplementOfTask2()
        {
            try
            {
                IndexOutOfRangeExceptionTask.IndexOutOfRangeMethod();
            }
            catch (IndexOutOfRangeException ex)
            {
                logger.Log(LogLevel.Error, ex.Message);
            }
        }

        private void ImplementOfTask4()
        {
            // StackOverflowException
            // try
            // {
            //     StackOverflowExceptionTask.Factorial(1);
            // }
            // catch (StackOverflowException ex)
            // {
            //     log.Write(ex.Message);
            // }
            // catch (Exception ex)
            // {
            //     log.Write(ex.Message);
            // }

            // IndexOutOfRangeException
            try
            {
                IndexOutOfRangeExceptionTask.IndexOutOfRangeMethod();
            }
            catch (IndexOutOfRangeException ex)
            {
                logger.Log(LogLevel.Error, ex.Message);
            }
            catch (Exception ex)
            {
                logger.Log(LogLevel.Error, ex.Message);
            }
        }

        private void ImplementOfTask5()
        {
            ArgumentExceptionTask exception = new ArgumentExceptionTask();

            // writeReadOfData.Write("======Task Of Exception========");
            // writeReadOfData.Write("Input a number: ");
            try
            {
                exception.DoSomeMath();
            }
            catch (ArgumentException ex)
            {
                logger.Log(LogLevel.Error, ex.Message);
            }
        }
    }
}

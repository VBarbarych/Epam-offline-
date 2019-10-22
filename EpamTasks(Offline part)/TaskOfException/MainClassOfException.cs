using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryOfInterfacesAndClasses.AdditionalClasses;
using LibraryOfInterfacesAndClasses.AdditionalInterfaces;
using Logger;
using TaskOfException.Task1;
using TaskOfException.Task2;

namespace TaskOfException
{
    public class MainClassOfException : IRunable
    {

        private IWriteReadable WriteReadOfData;
        public MainClassOfException(IWriteReadable writeReadOfData)
        {
            this.WriteReadOfData = writeReadOfData;
        }

        ILogging logger;

        public MainClassOfException(ILogging logger)
        {
            this.logger = logger;
        }


        private void ImplementOfTask1()
        {
            StackOverflowExceptionTask.Factorial(1);
        }

        private void ImplementOfTask2()
        {
            IndexOutOfRangeExceptionTask.IndexOutOfRangeMethod();
        }

        private void ImplementOfTask4()
        {
            //StackOverflowException
            //try
            //{
            //    StackOverflowExceptionTask.Factorial(1);
            //}
            //catch (StackOverflowException ex)
            //{
            //    log.Write(ex.Message);
            //}
            //catch (Exception ex)
            //{
            //    log.Write(ex.Message);
            //}

            //IndexOutOfRangeException
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

            try
            {
                exception.DoSomeMath();
            }
            catch(ArgumentException ex)
            {
                logger.Log(LogLevel.Error, ex.Message);
            }
        }

        public void Run()
        {
            //ImplementOfTask1();
            //ImplementOfTask2();
            ImplementOfTask4();
            //ImplementOfTask5();
        }
    }
}

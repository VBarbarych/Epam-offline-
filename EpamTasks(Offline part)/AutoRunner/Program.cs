using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryOfInterfacesAndClasses.AdditionalInterfaces;
using TaskOfStruct;
using TaskOfEnum;
using TaskOfIOStream;
using TaskOfException;
using TaskOfSerializations;
using TaskWithExcel;
using Logger;
using TaskOfReflection;
using LibraryOfInterfacesAndClasses.AdditionalClasses;


namespace AutoRunner
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IRunable> tasks = new List<IRunable>();

            IWriteReadable data = new ConsoleData();
            ILogging logger = new FileLogger();

            //tasks.Add(new MainClassOfStruct(data));
            //tasks.Add(new MainClassOfEnum(data, logger));
            //tasks.Add(new MainClassOfIOStream(data, logger));
            //tasks.Add(new MainClassOfException(data, logger));
            //tasks.Add(new MainClassOfSerializations(data, logger));
            //tasks.Add(new MainClassOfReflection(data));
            tasks.Add(new MainClassOfExcel(data, logger));


            foreach (var task in tasks)
            {
                task.Run();
            }

            Console.ReadKey();
        }
    }
}

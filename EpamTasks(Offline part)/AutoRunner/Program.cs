using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using TaskOfStyleCop;
using TaskWithDirectories;

namespace AutoRunner
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch sw_total = new Stopwatch();
            sw_total.Start();

            List<IRunable> tasks = new List<IRunable>();

            IWriteReadable output = new ConsoleData();
            ILogging logger = new FileLogger();

            tasks.Add(new MainClassOfStruct(output, logger));
            tasks.Add(new MainClassOfEnum(output, logger));
            tasks.Add(new MainClassOfIOStream(output, logger));
            tasks.Add(new MainClassOfException(output, logger));
            tasks.Add(new MainClassOfSerializations(output, logger));
            tasks.Add(new MainClassOfReflection(output));
            tasks.Add(new MainClassOfStyleCop(output));
            tasks.Add(new MainClassOfExcel(output, logger));
            tasks.Add(new MainClassOfDirectories(output, logger));

            foreach (var task in tasks)
            {
                task.Run();
            }

            sw_total.Stop();
            output.Write("Execute time: " + sw_total.ElapsedMilliseconds + " ms");
            Console.ReadKey();
        }
    }
}

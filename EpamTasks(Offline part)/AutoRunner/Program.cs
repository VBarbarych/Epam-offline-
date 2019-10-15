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

namespace AutoRunner
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IRunable> tasks = new List<IRunable>();

            tasks.Add(new MainClassOfStruct());
            tasks.Add(new MainClassOfEnum());
            tasks.Add(new MainClassOfIOStream());
            //tasks.Add(new MainClassOfException());

            foreach (var task in tasks)
            {
                task.Run();
            }


            Console.ReadKey();

        }
    }
}

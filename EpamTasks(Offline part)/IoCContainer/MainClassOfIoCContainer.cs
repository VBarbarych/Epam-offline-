using IoCContainer.IoCContainer;
using IoCContainer.Models;
using LibraryOfInterfacesAndClasses.AdditionalInterfaces;
using Logger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoCContainer
{
    public class MainClassOfIoCContainer : IRunable
    {
        private IWriteReadable writeReadOfData;
        private ILogging logger;

        public MainClassOfIoCContainer(IWriteReadable writeReadOfData, ILogging logger)
        {
            this.writeReadOfData = writeReadOfData;
            this.logger = logger;
        }


        public void Run()
        {
            writeReadOfData.Write("\n=========================================")
            writeReadOfData.Write("\nCreate own Ioc Container\n");

            var services = new IoCServiceCollection();

            services.RegisterSingleton<ICar, BMW>();
            //services.RegisterTransient<ICar, BMW>();
            //services.RegisterSingleton<ICar, Audi>();

            var container = services.GenerateContainer();

            var serviceFirst = container.GetService<ICar>();
            var serviceSecond = container.GetService<ICar>();

            serviceFirst.Move();
            serviceSecond.Move();
        }
    }
}

using LibraryOfInterfacesAndClasses.AdditionalInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace TaskOfReflection
{
    public class MainClassOfReflection :IRunable
    {
        IWriteReadable WriteReadOfData;

        public MainClassOfReflection(IWriteReadable writeReadOfData)
        {
            this.WriteReadOfData = writeReadOfData;
        }

        public void ImplementTask1()
        {
            WriteReadOfData.Write("\n====TaskOfReflection=====\n");
            Type type = Type.GetType("TaskOfReflection.Car");

            foreach(MemberInfo mi in type.GetMembers())
            {
                WriteReadOfData.Write($"{mi.DeclaringType} {mi.MemberType} {mi.Name}");
            }

            Type type1 = Type.GetType("TaskOfReflection.MainClassOfReflection");

            WriteReadOfData.Write("===============");
            foreach (MemberInfo mi in type1.GetMembers())
            {
                WriteReadOfData.Write($"{mi.DeclaringType} {mi.MemberType} {mi.Name}");
            }

        }


        public void ImplementTask2()
        {
            WriteReadOfData.Write("==============");
            Assembly asm = Assembly.LoadFrom("TaskOfReflection.dll");

            WriteReadOfData.Write(asm.FullName);
            // получаєм всі типи із збірки TaskOfReflection.dll
            Type[] types = asm.GetTypes();
            foreach (Type t in types)
            {
                WriteReadOfData.Write(t.Name);
            }
        }


        public void Run()
        {
            ImplementTask1();
            ImplementTask2();
        }
    }
}

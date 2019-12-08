using System;
using System.Reflection;
using LibraryOfInterfacesAndClasses.AdditionalInterfaces;

namespace TaskOfReflection
{
    public class MainClassOfReflection : IRunable
    {
        private IWriteReadable writeReadOfData;

        public MainClassOfReflection(IWriteReadable writeReadOfData)
        {
            this.writeReadOfData = writeReadOfData;
        }

        public void Run()
        {
            ImplementTask1();
            ImplementTask2();
        }

        public void ImplementTask1()
        {
            writeReadOfData.Write("\n====TaskOfReflection=====\n");
            Type type = Type.GetType("TaskOfReflection.Car");

            foreach (MemberInfo mi in type.GetMembers())
            {
                writeReadOfData.Write($"{mi.DeclaringType} {mi.MemberType} {mi.Name}");
            }

            Type type1 = Type.GetType("TaskOfReflection.MainClassOfReflection");

            writeReadOfData.Write("===============");
            foreach (MemberInfo mi in type1.GetMembers())
            {
                writeReadOfData.Write($"{mi.DeclaringType} {mi.MemberType} {mi.Name}");
            }
        }

        public void ImplementTask2()
        {
            writeReadOfData.Write("==============");
            Assembly asm = Assembly.LoadFrom("TaskOfReflection.dll");

            writeReadOfData.Write(asm.FullName);

            // получаєм всі типи із збірки TaskOfReflection.dll
            Type[] types = asm.GetTypes();
            foreach (Type t in types)
            {
                writeReadOfData.Write(t.Name);
            }
        }
    }
}

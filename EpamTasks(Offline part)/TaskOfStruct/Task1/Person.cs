using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskOfStruct.Task1
{
    struct Person : IPrint
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }

        public Person(string name, string surname, int age)
        {
            Name = name;
            Surname = surname;
            Age = age;
        }

        public string PrintString(int n)
        {
            return Age > n ? $"{Name} {Surname} older than {n}" : $"{Name} {Surname} younger than {n}";
        }
    }
}

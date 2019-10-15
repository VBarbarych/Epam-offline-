using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskOfEnum.Task2
{
    public static class EnumExtensionMethod
    {
        public static void EnumColorSort(this Color color)
        {
            List<int> ColorList = new List<int>();

            foreach (int i in Enum.GetValues(typeof(Color)))
            {
                ColorList.Add(i);
            }

            ColorList.Sort();

            foreach (int i in ColorList)
            {
                Console.WriteLine($"{Enum.GetName(typeof(Color), i)} = {i}");
            }
        }
    }
}

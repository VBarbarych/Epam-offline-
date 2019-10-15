using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskOfException.Task2
{
    static class IndexOutOfRangeExceptionTask
    {
        public static void IndexOutOfRangeMethod()
        {
            int[] numbers = new int[4];
            numbers[7] = 9;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskOfStruct.Task2
{
    interface ISize
    {
        double Width { get; set; }
        double Height { get; set; }
        double Perimeter();
    }
}

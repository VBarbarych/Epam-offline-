using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoCContainer.Models
{
    public class Audi : ICar
    {
        private int _miles = 0;

        public void Move()
        {
            Console.WriteLine($" {++_miles} miles");
        }

    }
}

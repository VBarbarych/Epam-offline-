using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskOfReflection
{
    public class Car
    {
        public Int32 Carld { get; set; }
        public decimal Price { get; set; }
        public Int32 Quantity { get; set; }
        public decimal Total { get; set; }

        public Car()
        {

        }

        public Car(Int32 carId, decimal price, Int32 quantity, decimal total)
        {
            this.Carld = carId;
            this.Price = price;
            this.Quantity = quantity;
            this.Total = total;
        }


        public void Do()
        {

        }
    }
}

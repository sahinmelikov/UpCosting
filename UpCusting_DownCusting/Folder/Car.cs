using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpCusting_DownCusting.Folder
{
    internal class Car : Vehicle
    {
        public override void Drive()
        {
            Console.WriteLine("it is Car");
        }
        public Car(double price) 
        {
            Price = price;
        }
        public Car()
        {
            ///////Bos ctor yaratmaq sebebim  program.cs 10 cu setirde bos gondere bilim deye,;)
        }
        public static bool operator >(Car a, Car b)
        {
            return a.Price > b.Price;
        }
        public static bool operator <(Car a, Car b)
        {
            return a.Price < b.Price;
        }
    }
}

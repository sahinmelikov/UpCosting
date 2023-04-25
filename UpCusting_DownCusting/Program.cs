using System.Security.Cryptography.X509Certificates;
using UpCusting_DownCusting.Folder;

namespace UpCusting_DownCusting
{
   internal class Program
    {
        static void Main(string[] args)
        {
            Vehicle vehicle = new Car();
            vehicle.Drive();

            Vehicle vehicle1 = new Bus();
           vehicle1.Drive();

            if (vehicle is Car)
            {
                Car car = (Car)vehicle;
                Console.WriteLine("vehicle do Car");
            }
            else
            {
                Console.WriteLine("vehicle don't Car ");
            }
            if (vehicle1 is Bus)
            {
                Bus bus = (Bus)vehicle1;
                Console.WriteLine("vehicle1 do Bus");
            }
            else
            {
                Console.WriteLine("vehicle1 don't Bus ");
            }

            Car car1 = new Car(435);
           
            Car car2 = new Car(566);


            Console.WriteLine(car1>car2);




        }


    }
}
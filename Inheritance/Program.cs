using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Car jacobCar = new Car();
            Motorbike jacobBike = new Motorbike();
            jacobCar.beep();
            jacobBike.beep();
            jacobBike.wheelie();
            // jacobCar.wheelie(); // whaaaa?
            

            Console.WriteLine(jacobCar.brand);
        }
    }
}

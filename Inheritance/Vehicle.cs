using System;

namespace Inheritance
{
    public class Vehicle
    {
        public string brand = "Mercedes";
        public void beep()
        {
            Console.WriteLine("Beep.");
        }
    }

    class Car : Vehicle
    {
        public string modelName = "A Class";
    }

    class Motorbike : Vehicle
    {
        public string modelName = "Harley";

        public void wheelie()
        {
            Console.WriteLine("What a rush.");
        }
    }
}

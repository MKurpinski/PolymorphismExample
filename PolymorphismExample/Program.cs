using System;
using PolymorphismExample.Vehicles;

namespace PolymorphismExample
{
    class Program
    {
        static void Main(string[] args)
        {
            IntroduceCar();
            PrintBreak();

            IntroduceBicycle();
            PrintBreak();

            IntroduceMotorcycle();
            PrintBreak();

            Console.ReadKey();
        }

        private static void IntroduceMotorcycle()
        {
            Motorcycle motorcycle = new Motorcycle();
            PrintAsDerivedClass(motorcycle.IntroduceYourself());
            PrintAsBaseClass(IntroduceVehicle(motorcycle));
        }

        private static void IntroduceBicycle()
        {
            Bicycle bicycle = new Bicycle();
            PrintAsDerivedClass(bicycle.IntroduceYourself());
            PrintAsBaseClass(IntroduceVehicle(bicycle));
        }

        private static void IntroduceCar()
        {
            Car car = new Car();
            PrintAsDerivedClass(car.IntroduceYourself());
            PrintAsBaseClass(IntroduceVehicle(car));
        }

        private static void PrintBreak()
        {
            Console.WriteLine("---------------------------------------");
        }
        private static string IntroduceVehicle(Vehicle vehicle)
        {
            return vehicle.IntroduceYourself();
        }

        private static void PrintAsDerivedClass(string message)
        {
            Console.WriteLine($"As Derived Class: {message}");
        }
        private static void PrintAsBaseClass(string message)
        {
            Console.WriteLine($"As Base Class: {message}");
        }
    }
}

using System;

namespace FactoryPatternExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int tires;

            Console.WriteLine("Please enter the number of tires you desire: ");
            tires = int.Parse(Console.ReadLine());

            IVehicle vehicle = VehicleFactory.GetVehicle(tires);

            if (vehicle != null)
            {
                vehicle.Drive();
            }
        }
    }
}

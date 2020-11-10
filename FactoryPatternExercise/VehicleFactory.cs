using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternExercise
{
    public static class VehicleFactory
    {
        public static IVehicle GetVehicle(int tires)
        {
            if (tires == 4)
            {
                return new Car();
            }
            else if (tires == 2)
            {
                return new Motorcycle();
            }
            else if (tires == 0)
            {
                return new Boat();
            }
            else
            {
                Console.WriteLine("We don't make any vehicles with that many tires");
                return null;
            }
        }
    }
}

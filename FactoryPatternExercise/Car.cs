using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternExercise
{
    class Car : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("Building a new car");
        }
    }
}

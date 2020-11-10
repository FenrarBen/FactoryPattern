using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternExercise
{
    class Motorcycle : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("Building a new motocycle");
        }
    }
}

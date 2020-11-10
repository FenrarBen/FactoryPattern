using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternExercise
{
    class Boat : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("Building a new boat");
        }
    }
}

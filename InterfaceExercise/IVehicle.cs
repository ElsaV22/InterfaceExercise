using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    interface IVehicle
    {
        public int NumberOfWheels { get; set; }
        public string Color { get; set; }
        public string Make { get; set; }
        public int YearMade { get; set; }
    }

}

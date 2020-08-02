using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public class Car : ICompany, IVehicle
    {
        public bool HasTrunk { get; set; }
        public int NumberOfDoors { get; set; }
        public bool HasTrailer { get; set; }
        public bool IsCommercial { get; set; }
        public int NumberOfWheels { get; set; }
        public string Color { get; set; }
        public string Make { get; set; }
        public int YearMade { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }


    }
}

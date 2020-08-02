using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    class SUV: IVehicle, ICompany
    {
        public bool HasCargoHold { get; set; }
        public bool Upgraded { get; set; }
        public bool HasTrailer { get; set; }
        public bool IsCommercial { get; set; }
        public int NumberOfWheels { get; set; }
        public string Color { get; set; }
        public string Make { get; set; }
        public int YearMade { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }

        public SUV(bool hasCargohold, string color)
        {
            HasCargoHold = hasCargohold;
            Color = color;
        }

    }
}

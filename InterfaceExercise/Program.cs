using System;
using System.Collections.Generic;
using System.Data.Common;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces 

            //Create 2 Interfaces called IVehicle & ICompany

            //Create 3 classes called Car , Truck , & SUV

            //In your IVehicle

            /* Create 4 members that Car, Truck, & SUV all have in common.
             * Example: All vehicles have a number of wheels... for now..
             */


            //In ICompany

            /*Create 2 members that are specific to each every company
             * regardless of vehicle type.
             *
             *
             * Example: public string Logo { get; set; }
             */

            //In each of your car, truck, and suv classes

            /*Create 2 members that are specific to each class
             * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
             * 
             */

            //Now, create objects of your 3 classes and give their members values;
            Truck myTruck = new Truck();
            myTruck.Color = "black";
            myTruck.IsCommercial = false;
            
            Car myCar = new Car()
            {
                HasTrunk = true
            };


            //Paramaterized CTOR
            SUV mySUV = new SUV(true, "blue"); 

            //Creatively display and organize their values

            Console.WriteLine($"Has a trailer {myTruck.HasTrailer}");

            //purpose of Interfaces
            List<IVehicle> trucks = new List<IVehicle>();
            trucks.Add(myTruck);
            trucks.Add(myCar);
            trucks.Add(mySUV);



        }
    }
}

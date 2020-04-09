using System;

namespace OOPIntro
{
    //Make sure to include the Vehicle class separate from the ObjectConstruction class
    public class Vehicle
    {
        //Accessibility of class members is defaulted to private
        //so we must add the public keyword to anything we
        //want to allow outside access to.

        // this unassigned integer will default to 0
        public int NumPassengers;
        //Notice the Constructor function doesn't need
        //a return type or the static keywordcopy

        //     constructor with an argument
        public Vehicle()
        {
            NumPassengers = 5;
        }


        //     constructor without an argument
        public Vehicle(int val)
        {
            NumPassengers = val;
        }
    }


    public class ObjectConstruction
    {
        public static void Main(string[] args)
        {
            //     constructor with an argument

            // Notice the type for the new object reference
            // is the same as the class name
            Vehicle myVehicle = new Vehicle();
            Console.WriteLine($"My vehicle is holding {myVehicle.NumPassengers} people");


            //     constructor with an argument

            // Notice the type for the new object reference
            // is the same as the class name
            Vehicle ourVehicle = new Vehicle(7);
            Console.WriteLine($"My vehicle is holding {ourVehicle.NumPassengers} people");
        }
    }
}

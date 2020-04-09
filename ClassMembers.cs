using System;

namespace OOPIntro
{
    public class Cars
    {
        public int MaxNumPassengers;
        public string Color;
        public double MaxSpeed;

        void MakeNoise(string noise)
        {
            Console.WriteLine(noise);
        }
        void MakeNoise()
        {
            Console.WriteLine("BEEP!");
        }

        // someCar.ColorProp => Color
        // someCar.ColorProp => "Some Color"
        string ColorProp
        {
            // you need to have at leat one accessor (get or set)
            get
            {
                if (Color == "Green")
                    return $"This Sweet thing is {Color}.";
                return $"This car is {Color}.";
            }
            set
            {
                if (value != "Green")
                    Color = value;
            }
        }

        string Name { get; set; }

    }

    // public static class ClassMembers
    // {
    //     public static void Main(string[] args)
    //     {
    //         Console.WriteLine();
    //     }
    // }

}
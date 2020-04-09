using System;

namespace OOPIntro
{
    class Automobile
    {
        private int maxNumPassengers;
        private string color;
        public int MaxNumPassengers
        {
            get { return maxNumPassengers; }
        }
        public string Color
        {
            get { return color; }
        }
        public Automobile(int maxPass, string col)
        {
            maxNumPassengers = maxPass;
            color = col;
        }
    }

    // public static class AccessModifiers
    // {
    //     public static void Main(string[] args)
    //     {
    //         Automobile v = new Automobile(5, "Green");

    //         Console.WriteLine(v.Color);
    //         Console.WriteLine(v.MaxNumPassengers);
    //     }
    // }

}
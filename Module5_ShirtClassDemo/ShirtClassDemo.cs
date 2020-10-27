using System;
using static System.Console;
//Name: James Shoemaker
//Date: 4/19/2020
//Program Description: Module 5

namespace Module5_ShirtClassDemo
{
    class ShirtClassDemo
    {
        static void Main(string[] args)
        {
            Shirt shirt1, shirt2, shirt3, shirt4, shirt5;
            shirt1 = new Shirt();
            shirt2 = new Shirt();
            shirt3 = new Shirt();
            shirt4 = new Shirt();
            shirt5 = new Shirt();

            //shirt 1
            shirt1.Material = "Cotton";
            shirt1.Color = "White";
            shirt1.Size = "L";

            //shirt 2
            shirt2.Material = "Cotton";
            shirt2.Color = "Blue";
            shirt2.Size = "XL";

            //shirt 3
            shirt3.Material = "Polyester";
            shirt3.Color = "Pink";
            shirt3.Size = "M";

            //shirt 4
            shirt4.Material = "Silk";
            shirt4.Color = "Yellow";
            shirt4.Size = "S";

            //shirt 5
            shirt5.Material = "Silk";
            shirt5.Color = "White";
            shirt5.Size = "XL";

            Display(shirt1, shirt2, shirt3);
            WriteLine();

            Display(shirt1, shirt2, shirt3, shirt4);
            WriteLine();

            Display(shirt1, shirt2, shirt3, shirt4, shirt5);
            WriteLine();
        }

        public static void Display(params Shirt[] shirts)
        {
            WriteLine("{0, -12} {1, -10} {2, -6}",
                "Material", "Color", "Size");

            foreach(Shirt shirt in shirts)
            {
                WriteLine("{0, -11} {1, -10} {2, -6}",
                shirt.Material, shirt.Color, shirt.Size);
            }
        }
    }
    //Definition of the shirt class
    class Shirt
    {
        public string Material { get; set; }
        public string Color { get; set; }
        public string Size { get; set; }

    }
}

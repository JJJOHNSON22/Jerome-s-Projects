using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErrorsandExceptions
{
    //This class is main menu for the console app
    class DisplayMenu
    {
        public void Menu1()
        {
            MathmaticalFormulas Math = new MathmaticalFormulas();
            string display = "0";
            while (display != "9")
            {
                Console.Clear();
                Console.WriteLine("Choose which thing you want to do.");
                Console.WriteLine();
                Console.WriteLine("{1}:Area and circumference of a circle");
                Console.WriteLine("{2}:Volume of a hemisphere");
                Console.WriteLine("{3}:Area of a triangle");
                Console.WriteLine("{4}:Quadratic equation");
                Console.WriteLine("{9}Exit.");
                Console.WriteLine();
                display = Console.ReadLine();

                switch (display)
                {
                    case "1": Math.Circle(); break;
                    case "2": Math.Hemisphere(); break;
                    case "3": Math.Triangle(); break;
                    case "4": Math.QuadraticEquation(); break;
                    case "9": break;
                    default: break;
                }
            }
           
        }
    }
}

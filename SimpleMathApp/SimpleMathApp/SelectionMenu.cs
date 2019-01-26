using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleMathApp
{
    class SelectionMenu
    {
        public void DisplayMenu()
        {
            int x = 0;
            int y = 0;
        displayMenu:

            Mathmatics Math = new Mathmatics();

            Console.Clear();
            string display = "0";
            Console.WriteLine("Welcome to the simple calculator!");
            Console.WriteLine();
            Console.WriteLine("{1}:Addition");
            Console.WriteLine("{2}:Subtraction");
            Console.WriteLine("{3}:Multiplication");
            Console.WriteLine("{4}:Division");
            Console.WriteLine("{9}Exit.");
            Console.WriteLine();
            display = Console.ReadLine();
            Console.WriteLine();

            while (display != "9")
            {
                try
                {
                    Console.Clear();

                    Console.WriteLine("What is the value of x?");
                    x = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("What is the value of y?");
                    y = Convert.ToInt32(Console.ReadLine());
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Number is too large, please try again.");
                    Console.ReadLine();
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input, please try again.");
                    Console.ReadLine();
                }
                catch (Exception)
                {
                    Console.WriteLine("Oops, please try again.");
                    Console.ReadLine();
                }


                if (display == "1")
                {
                    Math.Addition(x, y);
                    goto displayMenu;
                }
                else if (display == "2")
                {
                    Math.Subtraction(x, y);
                    goto displayMenu;
                }
                else if (display == "3")
                {
                    Math.Multiplication(x, y);
                    goto displayMenu;
                }
                else if (display == "4")
                {
                    if (y != 0)
                    {
                        Math.Division(x, y);
                        goto displayMenu;
                    }
                    else
                    {
                        Console.WriteLine("You can not divide by zero, try again!");
                        Console.ReadLine();
                    }
                }
                else if (display == "9")
                {
                    break;
                }
                else
                {
                    goto displayMenu;
                }
                
            }
        }
    }
}

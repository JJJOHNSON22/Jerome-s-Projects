using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Syntatic sugar is syntax that is designed to be easier to read and understand. It makes the code more human friendly as opposed to machine friendly.

namespace Homework2COptionalParameters
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string userSelection = "0";
            while (userSelection != "2")
            {
                Console.WriteLine("Welcome to the National Demographics Survey!");
                Console.WriteLine("{1}: Start Survey");
                Console.WriteLine("{2}: Exit");
                Console.WriteLine();
                userSelection = Console.ReadLine();
                Console.WriteLine();

                if (userSelection == "1")
                {

                   
                    Console.WriteLine("What is your name?" );
                    string name1 = Console.ReadLine();
                    Console.WriteLine();

                    Console.WriteLine("How old are you?" );
                    string age1 = Console.ReadLine();
                    Console.WriteLine();

                    Demographic(name1, age1);
                    Console.ReadLine();
                    
                    Console.WriteLine("Thank you for completing the survey");
                    Console.Read();

                    break;

                }
                else if (userSelection == "2")
                {
                    break;
                }
                else
                {
                    continue;
                }
            }
        }
        
        static void Demographic(string Name, string Age, string Race = "American", string placeOfBirth = "USA")
        {
            Console.WriteLine($"{Name}\n{Race}\n{Age}\n{placeOfBirth}");
        }
        


        /*
            Demographic.print();
            Demographic.print("Jerome");
            Demographic.print("Jerome", "American");
            Demographic.print("Jerome", "American", "22");
            Demographic.print("Jerome", "American", "22", "USA");
        
        }
        static class Demographic
        {
            public static void print()
            {
                Console.WriteLine("No value provided.");
            }
            public static void print(string Name)
            {
                Console.WriteLine(Name);
            }
            public static void print(string Name, string Ethnicity)
            {
                Console.WriteLine(Name, Ethnicity);
            }
            public static void print(string Name, string Ethnicity, string Age)
            {
                Console.WriteLine(Name, Ethnicity, Age);
            }
            public static void print(string Name, string Ethnicity, string Age, string Country)
            {
                Console.WriteLine(Name, Ethnicity, Age, Country);
            }
        }
        */
        }
    }


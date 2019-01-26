using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaAndCircumferenceOfCircleE1A
{
    class Program
    {
        static void Main(string[] args)
            
        //Input: radius = 4  Output: area = 50.27  circumference = 25.13
        //This project gives the area and circumference of a circle when the radius is givin.
        {
            Console.Write("Radius: ");
            double radius = double.Parse(Console.ReadLine());
            //the radius is converted to a double data type

            double pi = Math.PI;
            double area = pi * (radius * radius);
            double circumference = 2 * pi * radius;
            //the variable PI is declare here so I don't have to keep typing out Math.PI

            Console.WriteLine("Your area is: {0:0.00}", area);
            Console.WriteLine("Your circumference is: {0:0.00}", circumference);
            //Gives the result as a double with a max of two decimals
        }
    }
}

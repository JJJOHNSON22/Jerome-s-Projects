using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VolumeOfAHemisphereE1A
{
    class Program
    {
        static void Main(string[] args)

        //Input: radius = 3     Output: volume = 42.41in


        {
            Console.Write("Type in the radius of the hemisphere: ");
            double radius = double.Parse(Console.ReadLine());

            double pi = Math.PI;
            double volume = ((4 / 3) * pi * (radius * radius * radius)) / 2;

            Console.WriteLine("The volume of the hemisphere is: {0:0.00}in", volume);
        }
    }
}

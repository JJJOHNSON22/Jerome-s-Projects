using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaOfTriangleE1A
{
    class Program
    {
        static void Main(string[] args)

        //Input: side a = 3,  side b = 4,  side c = 5    Output: area = 69.03in

        {
            Console.Write("Type length of side a: ");
            double sideA = double.Parse(Console.ReadLine());

            Console.Write("Type length of side b: ");
            double sideB = double.Parse(Console.ReadLine());

            Console.Write("Type length of side c: ");
            double sideC = double.Parse(Console.ReadLine());

            double p = (sideA + sideB + sideC) / 2;
            // p = half the circumference

            double area = Math.Sqrt(p * (p - sideA) * (p - sideB) * (p - sideC));

            Console.WriteLine("The area of the triangle is: {0:0.00}in", area);

        }
    }
}

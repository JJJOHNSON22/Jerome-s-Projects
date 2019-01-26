using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolvingQuadraticEquationsE1A
{
    class Program
    {
        static void Main(string[] args)

        //Input: a = 4, b = 9, c = 5     Output: xPos = -1  xNeg = 1.25

        {
            Console.WriteLine("Quadratic Formula");
            Console.WriteLine();
            Console.WriteLine("ax ^ 2 + bx + c = 0");
            Console.WriteLine();

            Console.WriteLine("Type in the value of a: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Type in the value of b: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Type in the value of c: ");
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine();

            double root = (b * b) - (4 * (a * c));
            double xPos = (-b + Math.Sqrt(root)) / (2 * a);
            double xNeg = (+b + Math.Sqrt(root)) / (2 * a);

            if (root < 0)

            {
                Console.WriteLine("NaN");
            }

            else
            {
                Console.WriteLine("xPos = " + xPos + " xNeg = " + xNeg);
            }

        }
    }
}

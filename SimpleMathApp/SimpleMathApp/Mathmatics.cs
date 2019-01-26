using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleMathApp
{
    public class Mathmatics
    {
        public void Addition(int x, int y)
        {
            Console.WriteLine($"{x} + {y} = {x += y}");
            Console.ReadLine();
        }

        public void Subtraction(int x, int y)
        {
            Console.WriteLine($"{x} - {y} = {x -= y}");
            Console.ReadLine();
        }

        public void Multiplication(int x, int y)
        {
            Console.WriteLine($"{x} * {y} = {x *= y}");
            Console.ReadLine();
        }

        public void Division(int x, int y)
        {
            Console.WriteLine($"{x} / {y} = {x /= y}");
            Console.ReadLine();
        }
    }
}

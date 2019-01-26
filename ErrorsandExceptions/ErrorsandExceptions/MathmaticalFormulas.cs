using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErrorsandExceptions
{
    public class MathmaticalFormulas
    {
        public double input1;

        public void Circle()
        //Input: radius = 4  Output: area = 50.27  circumference = 25.13
        //This method gives the area and circumference of a circle when the radius is givin.
        {
            //the radius is converted to a double data type
            Console.Clear();
            DisplayMenu menu = new DisplayMenu();
            string input = "";

            Console.Write("Enter the radius of the circle in inches: ");
            input = Console.ReadLine();
            double radius = CheckNumber(input);
            
            if (radius > 0)
            {
                //the variable PI is declare here so I don't have to keep typing out Math.PI
                double pi = Math.PI;
                double area = pi * (radius * radius);
                double circumference = 2 * pi * radius;

                //Gives the result as a double with a max of two decimals
                Console.WriteLine($"Your area is: {area:0.00}in");
                Console.WriteLine($"Your circumference is: {circumference:0.00}in");
                Console.Read();
            }
            else if (radius == 0)
            {
                Console.WriteLine("Value must be greater than 0");
                Console.ReadLine();
            }
            else
            {

            }
        }

        public void Hemisphere()
        {
            //This method finds the volume of a hemisphere
            Console.Clear();
            string input = "";

            Console.Write("Type in the radius of the hemisphere: ");
            input = Console.ReadLine();
            double radius = CheckNumber(input);

            double pi = Math.PI;
            double volume = ((4 / 3) * pi * (radius * radius * radius)) / 2;

            Console.WriteLine($"The volume of the hemisphere is: {volume:0.00}in");
            Console.ReadLine();

        }

        public void Triangle()
        {
            //This method finds the area of a triangle
            Console.Clear();
            string input = "";

            Console.Write("Type length of side a: ");
            input = Console.ReadLine();
            double sideA = CheckNumber(input);

            Console.Write("Type length of side b: ");
            input = Console.ReadLine();
            double sideB = CheckNumber(input);

            Console.Write("Type length of side c: ");
            input = Console.ReadLine();
            double sideC = CheckNumber(input);

            // p = half the circumference
            double p = (sideA + sideB + sideC) / 2;
            double area = Math.Sqrt(p * (p - sideA) * (p - sideB) * (p - sideC));

            Console.WriteLine($"The area of the triangle is: {area:0.00}in");
            Console.ReadLine();
        }

        public void QuadraticEquation()
        {
            //This method solves quadratic equations
            Console.Clear();
            string input = "";

            Console.WriteLine("Quadratic Formula");
            Console.WriteLine();
            Console.WriteLine("ax ^ 2 + bx + c = 0");
            Console.WriteLine();

            Console.WriteLine("Type in the value of a: ");
            input = Console.ReadLine();
            double a = CheckNumber(input);

            Console.WriteLine("Type in the value of b: ");
            input = Console.ReadLine();
            double b = CheckNumber(input);

            Console.WriteLine("Type in the value of c: ");
            input = Console.ReadLine();
            double c = CheckNumber(input);

            double root = (b * b) - (4 * (a * c));
            double xPos = (-b + Math.Sqrt(root)) / (2 * a);
            double xNeg = (+b + Math.Sqrt(root)) / (2 * a);

            if (root < 0)

            {
                Console.WriteLine("NaN");
                Console.ReadLine();
            }

            else
            {
                Console.WriteLine($"xPos = {xPos:0.00} xNeg = {xNeg:0.00}");
                Console.ReadLine();
            }
        }

        public double CheckNumber(string input)
        {
            double input1 = 0;
            try
            {
                input1 = checked(Convert.ToDouble(input));
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
                Console.WriteLine("Invalid input, please try again.");
                Console.ReadLine();
            }
            finally
            {
                Console.WriteLine("Going back to menu...");
            }
            return input1;

        }
    }
}

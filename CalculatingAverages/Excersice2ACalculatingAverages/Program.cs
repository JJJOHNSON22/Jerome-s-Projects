using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excersice2ACalculatingAverages
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayMenu();
        }
        public static int SumValues()
        {
            Console.Clear();
            int sum = 0;
            int inputVal = 0;
            int totalValues = 10;
            int numOfValue = 0;
            Console.Write("Please enter ten values: ");
            Console.WriteLine();

            for (numOfValue = 1; numOfValue <= totalValues; numOfValue++)
            {
                Console.Write($"Value {numOfValue}: ");

                inputVal = Convert.ToInt32(Console.ReadLine());

                if (inputVal >= 0 && inputVal <= 100)
                {
                    sum += inputVal;
                }

                else
                {
                    Console.WriteLine("Value is not in range.");
                    Console.ReadLine();
                }
            }

            return sum;
        }

        public static int Average()
        {
            int sum = SumValues();
            int averageValue = 0;
            averageValue = sum / 10;
            return averageValue;
        }

        public static int TestAveragesS()
        {
            Console.Clear();
            int testNumber = 0;
            int testScore = 0;
            int testSum = 0;
            Console.WriteLine("Enter the amount of tests to grade: ");
            int numTests = Convert.ToInt32(Console.ReadLine());
            for (testNumber = 1; testNumber <= numTests; testNumber++)
            {
                Console.WriteLine($"\nTest Number {testNumber}: ");
                testScore = Convert.ToInt32(Console.ReadLine());
                if (testScore >= 0 && testScore <= 100)
                {
                    testSum += testScore;
                }
                else
                {
                    Console.WriteLine("Invalid test score.");
                    Console.ReadLine();
                }
            }
            return (testSum / numTests);

        }

        public static int TestAveragesNS()
        {
            Console.Clear();
            int testNumber = 1;
            int testScore = 0;
            int testSum = 0;
            Console.WriteLine($"Start entering test scores.\nEnter 999 to get average score.");
            while (testScore != 999)
            {
                    Console.WriteLine($"\nTest Number {testNumber}: ");
                    testScore = Convert.ToInt32(Console.ReadLine());
                    
                    if (testScore == 999)
                    {
                        return (testSum / (testNumber - 1));
                    }
                    else if (testScore >= 0 && testScore <= 100)
                    {
                        testSum += testScore;
                        testNumber++;
                    }
                    else
                    {
                        Console.WriteLine("Invalid test score.");
                        Console.ReadLine();
                    }
            }
            return 0;
        }
        


        public static void DisplayMenu()
        {
            displayMenu:
            Console.Clear();
            string display = "0";
            Console.WriteLine("Welcome to calculating averages!");
            Console.WriteLine();
            Console.WriteLine("{1}Sum of numbers.");
            Console.WriteLine("{2}Average ten scores.");
            Console.WriteLine("{3}Average a specific number of scores.");
            Console.WriteLine("{4}Average a non specific number of scores.");
            Console.WriteLine("{9}Exit.");
            Console.WriteLine();
            display = Console.ReadLine();
            Console.WriteLine();

            while (display != "9")
                if (display == "1")
                {
                    int sum = SumValues();
                    Console.WriteLine("Total sum is: " + sum);
                    Console.ReadLine();
                    goto displayMenu;
                }
                else if (display == "2")
                {
                    int averageValue = Average();
                    Console.WriteLine("Your average value is: " + averageValue);
                    Console.WriteLine(LetterGrades(averageValue));
                    Console.ReadLine();
                    goto displayMenu;
                }
                else if (display == "3")
                {
                    int testSum = TestAveragesS();
                    string letter = LetterGrades(testSum);
                    Console.WriteLine($"\nYour average test score is: {testSum}\nAverage letter grade is: {letter}");
                    Console.WriteLine();
                    Console.ReadLine();
                    goto displayMenu;
                }
                else if (display == "4")
                {
                    int testSum = TestAveragesNS();
                    string letter = LetterGrades(testSum);
                    Console.WriteLine($"\nYour average test score is: {testSum}\nAverage letter grade is: {letter}");
                    Console.WriteLine();
                    Console.ReadLine();
                    goto displayMenu;
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

        public static string LetterGrades(int averageValue)
        {
            if (averageValue <= 100 && averageValue >= 90)
            {
                return "A";
            }
            else if(averageValue <= 89 && averageValue >= 80)
            {
                return "B";
            }
            else if(averageValue <= 79 && averageValue >=70)
            {
                return "C";
            }
            else if(averageValue <= 69 && averageValue >= 60)
            {
                return "D";
            }
            else
            {
                return "F";
            }
        }

    }


    
}

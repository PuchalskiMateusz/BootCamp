using System;

namespace MyApplication
{
    class Program
    {
         static void WorkWithIntegers()
        {
            int a = 18;
            int b = 6;
            int c = a + b;
            Console.WriteLine(c);


            // subtraction
            c = a - b;
            Console.WriteLine(c);

            // multiplication
            c = a * b;
            Console.WriteLine(c);

            // division
            c = a / b;
            Console.WriteLine(c);
        }
        static void OrderPrecedence()
        {
            int a = 5;
            int b = 4;
            int c = 2;
            int d = (a + b) * c;
            Console.WriteLine(d);
            d = (a + b) - 6 * c + (12 * 4) / 3 + 12;
            Console.WriteLine(d);

            int e = 7;
            int f = 4;
            int g = 3;
            int h = (e + f) / g;
            Console.WriteLine(h);
        }

        static void TestLimits()
        {
            int a = 7;
            int b = 4;
            int c = 3;
            int d = (a + b) / c;
            int e = (a + b) % c;
            Console.WriteLine($"quotient: {d}");
            Console.WriteLine($"remainder: {e}");
            int max = int.MaxValue;
            int min = int.MinValue;
            Console.WriteLine($"The range of integers is {min} to {max}");
            int what = max + 3;
            Console.WriteLine($"An example of overflow: {what}");
        }

        static void WorkWithDoubles()
        {
            double a = 5;
            double b = 4;
            double c = 2;
            double d = (a + b) / c;
            Console.WriteLine(d);

            double e = 19;
            double f = 23;
            double g = 8;
            double h = (e + f) / g;
            Console.WriteLine(h);

            double max = double.MaxValue;
            double min = double.MinValue;
            Console.WriteLine($"The range of double is {min} to {max}");

            double third = 1 / 3.0;
            Console.WriteLine(third);

            double i = 7493.8265;
            double j = 41.145;
            double k = 6;
            double l = 75.908;
            double calc = (i * j + (k - l)) / i;
            Console.WriteLine(calc);
        }

        static void WorkWithDecimals()
        {
            decimal min = decimal.MinValue;
            decimal max = decimal.MaxValue;
            Console.WriteLine($"The range of the decimal type is {min} to {max}");

            double a = 1.0;
            double b = 3.0;
            Console.WriteLine("Double:" + (a / b));

            decimal c = 1.0M;
            decimal d = 3.0M;
            Console.WriteLine("Decimal:"+ (c / d));
        }

        static void CircleArea()
        {
            Console.WriteLine("Type circle radius: ");
            var r = Convert.ToDouble(Console.ReadLine());
            double area = Math.PI * r * r;
            Console.WriteLine(area);
        }
        static void Main(string[] args)
        {
            WorkWithIntegers();
            Console.WriteLine("\n");

            OrderPrecedence();
            Console.WriteLine("\n");

            TestLimits();
            Console.WriteLine("\n");

            WorkWithDoubles();
            Console.WriteLine("\n");

            WorkWithDecimals();
            Console.WriteLine("\n");

            CircleArea();

        }
    }
}
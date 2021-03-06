using System;

namespace BranchesAndLoops
{
    class Program
    {
        static void ExploreIf()
        {
            int a = 5;
            int b = 5;
            int c = 4;

            if ((a + b + c > 10) && (a == b))
            {
                Console.WriteLine("The answer is greater than 10.");
                Console.WriteLine("And the first number is equal to second");
            }
            else
            {
                Console.WriteLine("The answer is not greater than 10");
                Console.WriteLine("Or the first number is not equal to the second");
            }

            if ((a + b + c > 10) || (a == b))
            {
                Console.WriteLine("The answer is greater than 10");
                Console.WriteLine("Or the first number is equal to the second");
            }
            else
            {
                Console.WriteLine("The answer is not greater than 10");
                Console.WriteLine("And the first number is not equal to the second");
            }
        }

        static void Loops()
        {
            int counter = 0;
            while (counter < 10)
            {
                Console.WriteLine($"Hello World! The counter is {counter}");
                counter++;
            }
            Console.WriteLine("\n");

            counter = 0;
            do
            {
                Console.WriteLine($"Hello World! The counter is {counter}");
                counter++;
            } while (counter < 10);
            Console.WriteLine("\n");

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Hello World! The index os {i}");
            }
            Console.WriteLine("\n");
        }

        static void NestedLoops()
        {
            for (int row = 1; row < 11; row++)
            {
                Console.WriteLine($"The row is {row}");
            }

            for (char column = 'a'; column < 'k'; column++)
            {
                Console.WriteLine($"The column is {column}");
            }

            for (int row = 1; row < 11; row++)
            {
                for (char column = 'a'; column < 'k'; column++)
                {
                    Console.WriteLine($"The cell is ({row}, {column})");
                }
            }

            for (char column = 'a'; column < 'k'; column++)
            {
                for (int row = 1; row < 11; row++)
                {
                    Console.WriteLine($"The cell is ({row}, {column})");
                }
            }
        }

        static void Challenge()
        {
            int sum = 0;
            for (int i = 1; i < 21; i++)
            {
                if (i%3==0)
                {
                    sum += i;
                }
            }
            Console.WriteLine(sum);
        }

        static void Main(string[] args)
        {

            //ExploreIf();
            //Loops();
            //NestedLoops();
            Challenge();

        }
    }
}

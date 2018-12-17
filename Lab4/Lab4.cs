using System;

namespace Project 
{
    public class Test
    {
        public class Utils
        {
            public static int Greater(int a, int b)
            {
                int c = 0;
                if(a>b) { c = a; }
                else c = b;
                return c;
            }

            public static void Swap(ref int a, ref int b)
            {
                int temp = a;
                a = b;
                b = temp;
            }

            public static bool Factorial(int number, out int answer)
            {
                answer = 1;
                for(int i = 1; i <= number; i++)
                {
                    answer *= i;
                }

                if (0 < answer && answer < 2147483647)
                {
                    return true;
                }
                else
                {
                    throw new OverflowException(" EXCEED INTEGER LIMIT ");
                }
            }

            public static int RecursiveFactorial(int number)
            {
                if(number == 0 || number == 1)
                    return 1;
                 else
                     return number*RecursiveFactorial(number - 1);
            }

            public static void Main()
            { 
                int x,y,greater;
                Console.WriteLine("Please enter a first number: ");
                x = int.Parse(Console.ReadLine());
                Console.WriteLine("Please enter a second number: ");
                y = int.Parse(Console.ReadLine());
                Console.WriteLine("Please enter a third number: ");
                greater = int.Parse(Console.ReadLine());
                greater = Greater(x, y);
                Console.WriteLine("The result of comparing the first and second numbers: " + greater);
                Console.WriteLine("First number: " + x);
                Console.WriteLine("Second number: " + y);
                Swap(ref x, ref y);
                Console.WriteLine("Result after executing the swap function: ");
                Console.WriteLine("First number: " + x);
                Console.WriteLine("Second number: " + y);

                int answer;
                Console.WriteLine("Please enter a number to calculate the factorial: ");
                int number = int.Parse(Console.ReadLine());

                try
                {
                    Factorial(number, out answer);
                    Console.WriteLine("Factorial of a number {0} = {1}", number, answer);
                    int RecursFact = RecursiveFactorial(number);
                    Console.WriteLine("Factorial of a number {0} = {1} (method RecursiveFactorial)", number, RecursFact);
                }   
                catch(Exception caught)
                {
                    Console.WriteLine("Exception: {0}", caught);
                }
            }
        }
    }
}
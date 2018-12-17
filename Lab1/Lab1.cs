using System;


namespace Project 
{
    public class Test
    {
        public static void Main()
        {
            // Упражнения № 1-3
            string myName;
            Console.WriteLine("Please enter your name");
            myName = Console.ReadLine();
            Console.WriteLine("Hello {0}", myName);

            // Упражнение № 4
            int i, j;
            string temp;
            Console.WriteLine("Please enter a first number: ");
            i = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter a string: ");
            temp = Console.ReadLine();
            i = int.Parse(temp);
            Console.WriteLine("String convert to int: " +i);
            Console.WriteLine("Please enter a second number: ");
            temp = Console.ReadLine();
            j = int.Parse(temp);
            try { 
                int k = i / j; 
                Console.WriteLine("Number 'k' = " + k);
            }
            catch(DivideByZeroException) {
                Console.WriteLine("Division of {0} by zero.", i); 
            }

        }
    }
}
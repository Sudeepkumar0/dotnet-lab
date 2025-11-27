using System;

class FactorialProgram
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int num = Convert.ToInt32(Console.ReadLine());

        // If-else to handle negative numbers
        if (num < 0)
        {
            Console.WriteLine("Factorial is not defined for negative numbers.");
        }
        else
        {
            long factorial = 1;

            // For loop to calculate factorial
            for (int i = 1; i <= num; i++)
            {
                factorial *= i;
            }

            Console.WriteLine($"Factorial of {num} is: {factorial}");
        }

        Console.ReadLine();
    }
}

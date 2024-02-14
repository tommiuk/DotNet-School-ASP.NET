using System;

namespace Mod_2_Lesson_8_Task_1_10
{
    public class Program
    {
        public static void Main(string[] args)

        //Iteration statements EXC 1 Prime numbers
        {
            int PrimeNumber;
            for (int i = 2; i <= 100; i++)
            {
                PrimeNumber = 2;
                while (PrimeNumber < i && i % PrimeNumber != 0)
                {
                    PrimeNumber++;
                }
                if (i == PrimeNumber)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}

//Iteration statements EXC 2 Find all even numbers from 0 to 1000
{
    int evenNumber = 0;
    do
    {
        if (evenNumber % 2 == 0)
        {
            Console.WriteLine(evenNumber);
        }
        evenNumber++;
    }
    while (evenNumber <= 1000);
}

//Iteration statements EXC 3 Fibonacci Numbers
{
    {
        Console.Write("Enter Fibonacci Number: ");
        int elementsNumber = int.Parse(Console.ReadLine());

        for (int a = 0; a < elementsNumber; a++)
        {
            Console.WriteLine($"{a + 1}: {FibonacciNumber(a)}");
        }
    }

    static int FibonacciNumber(int n)
    {
        if (n <= 1)
            return n;
        return FibonacciNumber(n - 1) + FibonacciNumber(n - 2);
    }
}

//Iteration statements EXC 4 Pyramid Pattern
{
    Console.Write("Enter a number to make a pyramid: ");
    if (int.TryParse(Console.ReadLine(), out int rows))
    {
        int i = 1;
        int loop = 1;
        while (i < rows)
        {
            for (int j = 0; j < loop; j++)
            {
                if (i <= rows)
                {
                    Console.Write($"{i++} ");
                }
            }
            loop++;
            Console.WriteLine();
        }
    }
}

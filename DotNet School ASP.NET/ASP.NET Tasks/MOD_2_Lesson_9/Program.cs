using System;

namespace Mod_2_Lesson_8_Task_1_10
{
    public class Program
    {
        public static void Main(string[] args)

        // Petle. Zad 1. Napisz program, który sprawdzi ile jest liczb pierwszych w zakresie 0 –100.
        // Loops. EXC 1. Check how many prime numbers there are in the range 0–100.
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
// Petle. Zad 2. Napisz program,w którym za pomocą pętli do...while znajdziesz wszystkie liczby parzyste z zakresu 0 –1000.
// Loops. EXC 2. Use the while loop to find all even numbers in the range 0–1000
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
// Petle. Zad 3.Napisz program, który dla liczb od 1 do 20 wyświetli na ekranie ich 3 potęgę.
// Loops. EXC 3.
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
// Petle. Zad 5.Napisz program, który dla liczb od 1 do 20 wyświetli na ekranie ich 3 potęgę.
// Loops. EXC 5.Numbers from 1 to 20 display their 3rd power on the screen.
{
    Console.WriteLine("Numbers from 1 to 20 are their 3rd power:");
    for (int i = 1; i <= 20; i++)
    {
        Console.Write(Math.Pow(i, 3) + ", ");
    }
    Console.WriteLine();
}
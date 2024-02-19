using System;

namespace MOD_2_8_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {

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

                // Petle. Zad 3. Napisz program, który zaimplementuje ciąg Fibonacciego i wyświetli go na ekranie.
                // Loops. EXC 3. Implement the Fibonacci sequence and display it on the screen.

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

                // Petle. Zad 4. Napisz program, który po podaniu liczby całkowitej wyświetli piramidę liczb od 1 do podanej liczby w formie jak poniżej:
                // 1
                // 23
                // 456
                // 78910
                // Loops. EXC 4. Pyramid Pattern

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

                // Petle. Zad 6. Napisz program, który dla liczb od 0 do 20 obliczy sumę wg wzoru:1 + ½+ 1/3 + ¼itd.
                // Loops. EXC 6. Calculate the sum for numbers from 0 to 20 according to the formula: 1 + ½ + 1/3 + ¼ etc.

                {
                    decimal sum = 0;
                    for (decimal i = 1; i <= 20; i++)
                    {
                        sum = sum + 1 / i;
                    }
                    Console.WriteLine($"{sum}");
                    Console.WriteLine("");
                }

                // Petle. Zad 7. Napisz program, który dla liczby zadanej przez użytkownika
                // narysuje diament o krótszej przekątnej o długości wprowadzonej przez użytkownika i wg wzoru:
                //     *
                //    ***
                //   *****
                //  *******
                // *********
                //  *******
                //   *****
                //    ***
                //     *
                // Loops. EXC 7. Draw a diamond with a shorter diagonal of the length entered by the user and according to the formula:

                {
                    Console.WriteLine("Enter the diagonal of the diamond: ");
                    if (int.TryParse(Console.ReadLine(), out int totalDiamonds))
                    {
                        int firstRow = 1;
                        if (totalDiamonds % 2 == 0)
                        {
                            firstRow++;
                        }
                        for (int i = firstRow; i <= totalDiamonds; i += 2)
                        {
                            for (int k = (totalDiamonds - i) / 2; k >= 0; k--)
                            {
                                Console.Write(" ");
                            }
                            for (int k = 1; k <= i; k++)
                            {
                                Console.Write("*");
                            }
                            Console.WriteLine();
                        }
                        for (int i = totalDiamonds - 2; i >= firstRow; i -= 2)
                        {
                            for (int k = 0; k < (totalDiamonds - i + 2) / 2; k++)
                            {
                                Console.Write(" ");
                            }
                            for (int k = 1; k <= i; k++)
                            {
                                Console.Write("*");
                            }
                            Console.WriteLine();
                        }
                    }
                }

                // Petle. Zad 8. Napisz program, który odwróci wprowadzony przez użytkownika ciąg znaków.
                // Dane testowe:
                // Abcdefg
                // Rezultat
                // Gfedcba
                // Loops. EXC 8. Reverse the string of characters entered above.

                {
                    Console.Write("Enter a word to reverse: ");
                    string word1 = Console.ReadLine();
                    string word2 = "";
                    for (int a = word1.Length - 1; a >= 0; a--)
                    {
                        word2 += word1[a];
                    }
                    Console.WriteLine(word2);
                    Console.WriteLine("");
                }

                // Petle. Zad 9. Napisz program, który zamieni liczbę dziesiętną na liczbę binarną.
                // Loops. EXC 9. Convert a decimal number to a binary number.


            }
        }
    }
}


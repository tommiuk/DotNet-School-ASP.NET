using System;


namespace Mod_2_Lesson_4_Exc_1
{
    public class Program
    {
        public static void Main(string[] args)

        //declare personal details

        {
            Console.WriteLine("Name:");
            {
                String Name = "Name";
                Console.ReadLine();
            }
            Console.WriteLine("Surname:");
            {
                string Surname = "Surname";
                Console.ReadLine();
            }
            Console.WriteLine("Age:");
            {
                string Age = Console.ReadLine();
            }
            Console.WriteLine("Gender: w-woman, m-male");
            char sex1 = 'w';
            char sex2 = 'm';
            Console.ReadLine();

            Console.WriteLine("Pesel:");
            {
                string Pesel = "Pesel";
                Console.ReadLine();
            }
            Console.WriteLine("Worker number:");
            {
                string workerNumber = "workerNumber";
                Console.ReadLine();
            }
        }
    }
}

//Task 2. 

{
    char variables1 = 'a';
    char variables2 = 'b';
    char variables3 = 'c';

    Console.WriteLine($"{variables3}, {variables2}, {variables1}");
}

//Task 3. Calculate the length of the diagonals

{
    double height = 4, length = 6.5, diagonal;
    diagonal = Math.Sqrt(Math.Pow(height, 2) + Math.Pow(length, 2));
    Console.WriteLine($"Diagonal: {diagonal}");
}

//Task 4. Two numerical variables and one text variable

{
    string text = "Szkoła Dotneta";
    int numberInt = 10;
    double numberDouble = 12.5;
}

//Task 5. Personal details

{
    Console.WriteLine("Please enter your Name:");
    {
        string Name = "Name";
        Console.ReadLine();
    }
    Console.WriteLine("Please enter your Surname:");
    {
        string Surname = "Surname";
        Console.ReadLine();
    }
    Console.WriteLine("Please enter your Phone Number:");
    {
        string phoneNumber = "Phone Number";
        Console.ReadLine();
    }
    Console.WriteLine("Please enter your Email:");
    {
        string emial = "Email";
        Console.ReadLine();
    }
    Console.WriteLine("Please enter your Id number:");
    {
        string idNumber = "Id number";
        Console.ReadLine();
    }
    Console.WriteLine("Please enter your height:");
    {
        double height;
        bool result = double.TryParse(Console.ReadLine(), out height);
    }
    Console.WriteLine("Please enter your weight:");
    {
        double weight;
        bool result2 = double.TryParse(Console.ReadLine(), out weight);
    }
    Console.WriteLine("Please enter your Age:");
    {
        string Age = "Age";
        Console.ReadLine();
    }
    Console.WriteLine("Please enter your gender: w-woman, m-male");
    char sex1 = 'w';
    char sex2 = 'm';
    Console.ReadLine();
}


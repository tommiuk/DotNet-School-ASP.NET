using System;

namespace Mod_2_Lesson_7_Task_1_13
{
    public class Program
    {
        public static void Main(string[] args)

        //Task 1. Create two variables int and check whether they are equal or not.

        {
            int a = 5;
            int b = 5;

            if (a == b)
            {
                Console.WriteLine($"{a} i {b} They are equal");
            }
            else
            {
                Console.WriteLine($"{a} i {b} They aren't equal");
            }
        }
    }
}

//Task 2. Check whether the number is even or odd

int a = 15;

if (a % 2 == 0)
{
    Console.WriteLine($"{a} the number is even");
}
else
{
    Console.WriteLine($"{a} the number is odd");
}

//Task 3. Check whether the number provided by the user is positive or negative.

{
    Console.WriteLine("Enter a number:");

    int chosenNumber = Int32.Parse(Console.ReadLine());

    if (chosenNumber > 0)
    {
        Console.WriteLine($"{chosenNumber} You entered a positive number");
    }
    else if (chosenNumber == 0)
    {
        Console.WriteLine($"{chosenNumber} You entered 0");
    }
    else
    {
        Console.WriteLine($"{chosenNumber} You entered a negative number");
    }

    //Task 4. Check if the entered a year is leap.

    {
        Console.WriteLine("Enter a Year:");

        int chosenYear = Int32.Parse(Console.ReadLine());

        if ((chosenYear % 4 == 0 && chosenYear % 100 != 0) || chosenYear % 400 == 0)
        {
            Console.WriteLine($"{chosenYear} The Year is leap");

        }
        else
        {
            Console.WriteLine($"{chosenYear} The Year is not leap");
        }
    }

    //Task 5. Check user age to be MP, Senator, PM or President

    {
        Console.WriteLine("Enter your age:");

        int chosenAge = Int32.Parse(Console.ReadLine());

        if (chosenAge >= 35)
        {
            Console.WriteLine($"{chosenAge} You can become: MP, Senator, Prime Minister or President ");
        }

        else if (chosenAge >= 30)
        {
            Console.WriteLine($"{chosenAge} You can become: MP, Senator, Prime Minister ");
        }

        else if (chosenAge >= 21)
        {
            Console.WriteLine($"{chosenAge}You can become: MP ");
        }
        else
        {
            Console.WriteLine("You are too young to become: MP ");
        }
    }

    //Task 6. What is your height...

    {
        Console.WriteLine("Please enter your height:");

        int chosenHeight = Int32.Parse(Console.ReadLine());

        if (chosenHeight < 120)
        {
            Console.WriteLine($"{chosenHeight} You are still a child ");
        }

        else if (chosenHeight < 140)
        {
            Console.WriteLine($"{chosenHeight} You are a dwarf ");
        }

        else if (chosenHeight < 160)
        {
            Console.WriteLine($"{chosenHeight} You are quite short in height ");
        }

        else if (chosenHeight < 180)
        {
            Console.WriteLine($"{chosenHeight} You are of normal height ");
        }

        else if (chosenHeight < 200)
        {
            Console.WriteLine($"{chosenHeight} You are tall ");
        }
    }

    //Task 7. Enter 3 digits and check which is the largest

    {
        Console.WriteLine("Please enter first number: ");
        decimal first = decimal.Parse(Console.ReadLine());

        Console.WriteLine("Please enter second number: ");
        decimal second = decimal.Parse(Console.ReadLine());

        Console.WriteLine("Please enter third number: ");
        decimal third = decimal.Parse(Console.ReadLine());

        if (first > second && first > third)
        {
            Console.WriteLine($"{first} is the largest number: ");
        }
        else if (second > first && second > third)
        {
            Console.WriteLine($"{second} is the largest number: ");
        }
        else
        {
            Console.WriteLine($"{third} is the largest number");
        }
    }

    //Task 8. Check whether the candidate can apply for a place at the university

    {
        Console.WriteLine("Please enter your GCSE Maths score: ");
        int maths = Int32.Parse(Console.ReadLine());

        Console.WriteLine("Please enter your GCSE Physics score: ");
        int physics = Int32.Parse(Console.ReadLine());

        Console.WriteLine("Please enter your GCSE Chemistry score: ");
        int chemistry = Int32.Parse(Console.ReadLine());

        if (maths + physics + chemistry > 180)
        {
            Console.WriteLine($"{maths + physics + chemistry} Your application was successful: ");
        }
        else if (maths + physics >= 150)
        {
            Console.WriteLine($"{maths + physics} Your application was successful: ");
        }
        else if (maths + chemistry >= 150)
        {
            Console.WriteLine($"{maths + chemistry} Your application was successful: ");
        }
        else
            Console.WriteLine("Your application was unsuccessful: ");
    }

    //Task 9. What is temperature?

    {
        Console.WriteLine("Podaj jaka jest temperatura: ");
        int temperatura = Int32.Parse(Console.ReadLine());

        if (temperatura < 0)
        {
            Console.WriteLine($"{temperatura} Cholernie pizdzi");
        }
        else if (temperatura < 10)
        {
            Console.WriteLine($"{temperatura} Zimno");
        }
        else if (temperatura < 20)
        {
            Console.WriteLine($"{temperatura} Chlodno");
        }
        else if (temperatura < 30)
        {
            Console.WriteLine($"{temperatura} W sam raz");
        }
        else if (temperatura < 40)
        {
            Console.WriteLine($"{temperatura} Zaczyna byc slabo, bo goraco");
        }
        else
        {
            Console.WriteLine("a wez wyprowadzam sie na Alaske");
        }
    }

    //Task 10. Check if you can build a triangle?

    {
        Console.WriteLine("Enter the length A: ");
        int side_A = Int32.Parse(Console.ReadLine());

        Console.WriteLine("Enter the length B: ");
        int side_B = Int32.Parse(Console.ReadLine());

        Console.WriteLine("Enter the length C: ");
        int side_C = Int32.Parse(Console.ReadLine());

        if (side_A + side_B > side_C)
        {
            Console.WriteLine($"{side_A + side_B > side_C} A triangle looks ok ");
        }
        else if (side_B + side_C > side_A)
        {
            Console.WriteLine($"{side_A + side_B > side_C} A triangle looks ok ");
        }
        else if (side_A + side_C > side_B)
        {
            Console.WriteLine($"{side_A + side_B > side_C} A triangle looks ok ");
        }
        else
        {
            Console.WriteLine("Unfortunately, you can't build the triangle");
        }
    }

    //Task 11. What is your grade?

    Console.WriteLine("Podaj swoją ocenę (1-6): ");
    byte number;
    Byte.TryParse(Console.ReadLine(), out number);

    switch (number)
    {
        case 1:
            Console.WriteLine("Niedostateczny");
            break;
        case 2:
            Console.WriteLine("Dopuszczający");
            break;
        case 3:
            Console.WriteLine("Dostateczny");
            break;
        case 4:
            Console.WriteLine("Dobry");
            break;
        case 5:
            Console.WriteLine("Bardzo dobry");
            break;
        case 6:
            Console.WriteLine("Celujący");
            break;
        default:
            break;
    }
}

//Task 12. Check the number of days

{
    Console.WriteLine("Enter day number (1-7): ");
    byte day;
    Byte.TryParse(Console.ReadLine(), out day);

    switch (day)
    {
        case 1:
            Console.WriteLine("Monday");
            break;
        case 2:
            Console.WriteLine("Tuesday");
            break;
        case 3:
            Console.WriteLine("Wednesday");
            break;
        case 4:
            Console.WriteLine("Thursday");
            break;
        case 5:
            Console.WriteLine("Friday");
            break;
        case 6:
            Console.WriteLine("Saturday");
            break;
        case 7:
            Console.WriteLine("Sunday");
            break;
        default:
            break;
    }
}

//Task 12. Calculator

{
    Console.WriteLine("Enter first number A: ");
    int a;
    Int32.TryParse(Console.ReadLine(), out a);
    Console.WriteLine("Enter second number B: ");
    int b;
    Int32.TryParse(Console.ReadLine(), out b);
    double result = 0;

    Console.WriteLine("1. Add \n2. Subtraction \n3. Multiplication \n4. Division");
    string choice = Console.ReadLine();
    switch (choice)
    {
        case "1":
            result = a + b;
            Console.WriteLine($"Result: {result}");
            break;
        case "2":
            result = a - b;
            Console.WriteLine($"Result: {result}");
            break;
        case "3":
            result = a * b;
            Console.WriteLine($"Result: {result}");
            break;
        case "4":
            result = a / b;
            Console.WriteLine($"Result: {result}");
            break;
        default:
            break;
    }
}


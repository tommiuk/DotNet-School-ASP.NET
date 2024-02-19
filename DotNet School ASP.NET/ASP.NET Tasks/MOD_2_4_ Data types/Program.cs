using System.Text;


// Typy danych. Zad 1. Stworz program, w ktorym zadeklarujesz zmienne dotyczace danych pracownika firmy:
// imie, nazwisko, pesel nr pracownika itp...
// Data types. EXC 1. Declare variables related to company employee data

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

// Typy danych. Zad 2. Napisz program, w którym stworzysz 3 zmienne z jedną literą,
// a następnie wypiszesz je w odwrotnej kolejności niż zostały zadeklarowane.
// Data types. EXC 2. Create three variables with one letter and then print them in the reverse order from which they were declared.
{
    char variables1 = 'a';
    char variables2 = 'b';
    char variables3 = 'c';

    Console.WriteLine($"{variables3}, {variables2}, {variables1}");
}

// Typy danych. Zad 3.Napisz program, który na podstawie podanej szerokości i długości prostokąta wyliczy długość przekątnej.
// (Aby, obliczyć kwadrat liczby użyj metody Math.Pow())
// Data types. EXC 3. Calculate the length of the diagonals using the method Math.Pow())

{
    double height = 4, length = 6.5, diagonal;
    diagonal = Math.Sqrt(Math.Pow(height, 2) + Math.Pow(length, 2));
    Console.WriteLine($"Diagonal: {diagonal}");
}


// Typy danych. Zad 4. Napisz program w którym stworzysz 2 zmienne liczbowe, oraz jedną tekstową,
// a następnie przypiszesz im następujące wartości:
// a.10
// b.Szkoła Dotneta
// c.12,5
// Pamiętaj o użyciu poprawnych typów danych
// Data types. EXC 4. Two numerical variables and one text variable

{
    string text = "Szkoła Dotneta";
    int numberInt = 10;
    double numberDouble = 12.5;
}

// Typy danych. Zad 3. Napisz program w którym poprosisz użytkownika o jego dane personalne:
// Imię, nazwisko, numer telefonu, adres email, wzrost, waga (np. 85,7), itp
// (postaraj się wymyślić jak najwięcej) i spróbuj przekonwertować odpowiedź
// do odpowiedniego typu danych używając metody: typDanych.Parse(odpowiedźOdUżytkownika). 
// Data types. EXC 3. Personal details using data type.Parse()

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


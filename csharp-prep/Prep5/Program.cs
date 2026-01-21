using System;
using System.Runtime.InteropServices;

class Program
{
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName()
    {
        Console.Write("What is your name? ");
        string name = Console.ReadLine();
        return name;
    }

    static int PromptUserNumber()
    {
        Console.Write("What is your favorite number? ");
        string numStr = Console.ReadLine();
        int numInt = int.Parse(numStr);
        return numInt;
    }

    static void PromptUserBirthYear(out int birth)
    {
        Console.Write("What year were you born? ");
        string birthStr = Console.ReadLine();
        birth = int.Parse(birthStr);
    }

    static int SquareNumber(int x)
    {
        int squared = x*x;
        return squared;
    }

    static void DisplayResult(string name, int square, int birth)
    {
        int age = 2026 - birth;
        Console.WriteLine($"Your name is {name}.");
        Console.WriteLine($"The square of your favorite number is {square}.");
        Console.WriteLine($"You will turn {age} this year.");
    }
    static void Main(string[] args)
    {
        DisplayWelcome();

        string name = PromptUserName();

        int number = PromptUserNumber();

        int birthYear = 0;
        PromptUserBirthYear(out birthYear);

        int squaredNum = SquareNumber(number);

        DisplayResult(name, squaredNum, birthYear);



    }
}
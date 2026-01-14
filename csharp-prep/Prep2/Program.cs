using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string stringPercent =Console.ReadLine();
        int intPercent = int.Parse(stringPercent);

        // define variable letterGrade
        string letterGrade = "";

        // check what the percentage is and update letterGrade variable
        if (intPercent >= 90)
        {
            letterGrade = "A";
        }
        else if (intPercent >= 80)
        {
            letterGrade = "B";
        }
        else if (intPercent >= 70)
        {
            letterGrade = "C";
        }
        else if (intPercent >= 60)
        {
            letterGrade = "D";
        }
        else
        {
            letterGrade = "F";
        }

        Console.WriteLine($"Your grade is {letterGrade}");

        // check if they passed or failed the class
        if (intPercent >= 70)
        {
            Console.WriteLine("Congratulations! You passed the class!!");
        }
        else
        {
            Console.WriteLine("You failed the class but if you study hard you will do better next time!");
        }
    }
}
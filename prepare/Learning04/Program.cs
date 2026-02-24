using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning04 World!");

        Assignment myAssignment = new Assignment("Madison Loutensock", "Programming with Classes");

        Console.WriteLine(myAssignment.GetSummary());

        MathAssignment myMath = new MathAssignment("Madison Loutensock", "Trigonometry", "8.6", "9-15");

        Console.WriteLine(myMath.GetSummary());
        
        Console.WriteLine(myMath.GetHomeworkList());

        WritingAssignment myWriting = new WritingAssignment("Madison Loutensock", "Creative Writing", "Another Dangerous Game");

        Console.WriteLine(myWriting.GetSummary());

        Console.WriteLine(myWriting.GetWritingInformation());
    }
}
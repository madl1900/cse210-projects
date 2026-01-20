using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the magic number generator!");
        Console.WriteLine("Where you try to guess the magic number!");
        Random randomGenerator = new Random();
        int magicNum = randomGenerator.Next(1, 100);
        
        int guessInt = 101;
        do
        {
            Console.Write("What is your guess? ");
            string guessStr = Console.ReadLine();
            guessInt = int.Parse(guessStr);

            if (guessInt > magicNum)
            {
            Console.WriteLine("Lower");   
            }
            else if (guessInt < magicNum)
            {
            Console.WriteLine("Higher");   
            }
            else
            {
            Console.WriteLine("You guessed it!");   
            }
        } while (guessInt != magicNum);
    }
}
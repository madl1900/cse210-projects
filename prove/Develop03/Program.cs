using System;
using System.Data;
/* I exceeded requirements for this assignment by having it only hide words that were not 
already hidden */
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the scripture memorizer!");

        Reference myRef = new Reference("1 Corinthians", 13, 13);
        string verse = "And now abideth faith, hope, charity, these three; but the greatest of these is charity.";
        Scripture myScripture = new Scripture(myRef, verse);
        myScripture.Run();
    }
}
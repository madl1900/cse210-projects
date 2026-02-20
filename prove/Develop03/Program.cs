using System;
using System.Data;
/* I exceeded requirements for this assignment by having it only hide words that were not 
already hidden and creating a CheckMemory function in the Scripture class that has the user
try typing in the whole verse after they have hidden all the words, then compares their words
to the actual verse. It then shows which words they got correct and how many.*/
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
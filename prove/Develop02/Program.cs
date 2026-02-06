using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the journal app!");

        Journal myJournal = new Journal();

        myJournal.ShowMenu();
    }
}
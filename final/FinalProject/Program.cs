using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        string mainMenuChoice = "";

        while (mainMenuChoice != "4")
        {
            Console.WriteLine("\nWelcome to the practice room!");

            PracticeLog myPractices = new PracticeLog();
            MusicManager myMusic = new MusicManager();
            InstrumentManager myInstruments = new InstrumentManager();
        
            Console.WriteLine();
            Console.WriteLine("Please choose an option from the menu:");
            Console.WriteLine("1. Practice Log\n2. Music manager\n3. Metronome\n4. Quit");
            mainMenuChoice = Console.ReadLine();

            if (mainMenuChoice == "1")
            {
                Console.WriteLine("What would you like to do in the practice log?");
                
                Console.WriteLine();
                Console.WriteLine("1. Create new practice entry\n2. Display current entries\n3. Save entries to file\n4. Load a file\n5. Exit Practice Log");

                // TODO: add practice log options

            }

            else if (mainMenuChoice == "2")
            {
                string musicMenuChoice = "";

                while (musicMenuChoice != "7")
                {
                    Console.WriteLine("What would you like to do in the music manager?");

                    Console.WriteLine();
                    Console.WriteLine("1. Add new music\n2. Display all music\n3. Add an instrument\n4. Display all instruments\n5. Save music to file\n6. Load a file\n7. Exit Music Manager");
                    musicMenuChoice = Console.ReadLine();
                    // TODO: add music manager options
                    if (musicMenuChoice == "1")
                    {

                    }
                    else if (musicMenuChoice == "2")
                    {
                        myMusic.DisplayMusic();
                    }
                }
            }

            else if (mainMenuChoice == "3")
            {
                Console.WriteLine("Welcome to the metronome!");

                Console.WriteLine();
                Console.Write("What tempo would you like the metronome to be? ");
                string tempoString = Console.ReadLine();

                int tempo = int.Parse(tempoString);

                Console.WriteLine();
                Console.Write("What time signature would you like? (ex: 4/4, 6/8) ");
                string timeSignature = Console.ReadLine();

                Console.WriteLine();
                Console.Write("How many seconds would you like the metronome to run? ");
                string durationString = Console.ReadLine();

                int duration = int.Parse(durationString);

                Metronome myMetronome = new Metronome(tempo, timeSignature, duration);

                // Add metronome Run method
            }
            else if (mainMenuChoice == "4")
            {
                break;
            }

            else
            {
                Console.WriteLine("You must choose an option from the menu.");
            }
        }
    }
}
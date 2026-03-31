using System;

class Program
{
    static void Main(string[] args)
    {
        string mainMenuChoice = "";

        while (mainMenuChoice != "5")
        {
            Console.WriteLine("\nWelcome to the practice room!");

            PracticeLog myPractices = new PracticeLog();
            MusicManager myMusic = new MusicManager();
            InstrumentManager myInstruments = new InstrumentManager();
        
            Console.WriteLine();
            Console.WriteLine("Please choose an option from the menu:");
            Console.WriteLine("1. Practice Log\n2. Music manager\n3. Instrument Manager\n4. Metronome\n5. Quit");
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
                Console.WriteLine("What would you like to do in the music manager?");

                Console.WriteLine();
                Console.WriteLine("1. Add new music\n2. Display all music\n3. Save music to file\n4. Load a file\n5. Exit Music Manager");

                // TODO: add music manager options
            }

            else if (mainMenuChoice == "3")
            {
                string instrMenuChoice = "";

                while (instrMenuChoice != "5")
                {
                    Console.WriteLine("What would you like to do in the instrument manager?");

                    Console.WriteLine();
                    Console.WriteLine("1. Add a new instrument\n2. Display all instruments\n3. Save instruments to file\n4. Load a file\n5. Exit Instrument Manager");
                    instrMenuChoice = Console.ReadLine();
                    
                    // TODO: add instrument manager options
                    if (instrMenuChoice == "1")
                    {
                        myInstruments.AddInstrument();
                    }

                    else if (instrMenuChoice == "2")
                    {
                        myInstruments.DisplayInstruments();
                    }

                    else if (instrMenuChoice == "3")
                    {
                        myInstruments.SaveInstruments();
                    }

                    else if (instrMenuChoice == "4")
                    {
                        myInstruments.LoadInstruments();
                    }

                    else if (instrMenuChoice == "5")
                    {
                        break;
                    }

                    else
                    {
                        Console.WriteLine("Please choose an option from the menu.");
                    }
                }
            }

            else if (mainMenuChoice == "4")
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
            else if (mainMenuChoice == "5")
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
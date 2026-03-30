using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the practice room!");

        PracticeLog myPractices = new PracticeLog();
        MusicManager myMusic = new MusicManager();
        InstrumentManager myInstruments = new InstrumentManager();
        Metronome myMetronome = new Metronome();
        
        Console.WriteLine();
        Console.WriteLine("Please choose an option from the menu:");
        Console.WriteLine("1. Practice Log\n2. Music manager\n3. Instrument Manager\n4. Metronome");
    }
}
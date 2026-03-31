public class InstrumentManager
{
    private List<Instrument> _instruments = new List<Instrument>();

    public void AddInstrument()
    {
        Console.WriteLine("What instrument would you like to add? ");
        string instr = Console.ReadLine().ToLower();

        Console.WriteLine("What type of instrument is it? (ex: woodwind) ");
        string type = Console.ReadLine().ToLower();

        Instrument myInstr = new Instrument(instr, type);
        _instruments.Add(myInstr);
    }

    public void DisplayInstruments()
    {
        foreach (Instrument instr in _instruments)
        {
            Console.WriteLine(instr.DisplayInstrument());
        }
    }

    public void SaveInstruments()
    {
        // TODO: save _instruments to a file
        Console.Write("Enter the name you want your file saved as: ");
        string filename = Console.ReadLine();
        
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Instrument instr in _instruments)
        {
            outputFile.WriteLine(instr.SaveInstrument());
        }
        }
    }

    public void LoadInstruments()
    {
        Console.Write("Enter the name of the file you want loaded: ");
        string filename = Console.ReadLine();

        if (File.Exists(filename))
        {
            _instruments.Clear();

            string[] lines = System.IO.File.ReadAllLines(filename);

            foreach (string line in lines)
            {
                string[] parts = line.Split(",");
                if (parts[0] == "Instrument")
                {
                    string instrName = parts[1];
                    string instrType = parts[2];

                    Instrument myInstr = new Instrument(instrName, instrType);
                    
                    _instruments.Add(myInstr);
                }
            }

            if (_instruments.Count() == 0)
            {
                Console.WriteLine("That file did not have any instruments.");
            }
        }
        
        else
        {
            Console.WriteLine("That file does not exist.");
        }
    }
}
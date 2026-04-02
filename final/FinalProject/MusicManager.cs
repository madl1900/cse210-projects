public class MusicManager
{
    private List<Music> _music = new List<Music>();
    private List<Instrument> _instruments = new List<Instrument>();

    public void AddMusic()
    {
        // add music to the corresponding type of music list
        Console.WriteLine("1. Song\n2. Scale");
        Console.Write("What type of music would you like to add? ");
        string musicChoice = Console.ReadLine();

        if (musicChoice == "1")
        {
            if (_instruments.Count() == 0)
            {
                Console.WriteLine("You must add an instrument first:");
                AddInstrument();
            }
            
            DisplayInstruments();
            Console.Write("Which instrument is this song for? ");
            string instrChoice = Console.ReadLine();
            int instrChoiceIndex = int.Parse(instrChoice) - 1;

            Instrument songInstr = _instruments[instrChoiceIndex];

            Console.Write("What is the name of the song? ");
            string name = Console.ReadLine();

            Console.Write("Who is the composer? ");
            string composer = Console.ReadLine();

            Console.Write("What is the song's tempo? ");
            int tempo = int.Parse(Console.ReadLine());

            Console.Write("What is the time signature? ");
            string timeSignature = Console.ReadLine();

            Console.Write("What key is the song in? ");
            string keySignature = Console.ReadLine();

            MusicPiece mySong = new MusicPiece(name, tempo, timeSignature, songInstr, composer, keySignature);
            _music.Add(mySong);
        }

        else if (musicChoice == "2")
        {
            Console.Write("What is the name of the scale? ");
            string name = Console.ReadLine();

            Console.Write("What tempo will the scale be? ");
            int tempo = int.Parse(Console.ReadLine());

            Console.Write("What is the time signature? ");
            string timeSignature = Console.ReadLine();

            Console.Write("How many beats will each note get? ");
            int rhythm = int.Parse(Console.ReadLine());

            MusicScale myScale = new MusicScale(name, tempo, timeSignature, rhythm);
            _music.Add(myScale);
        }
    }
    public void DisplayMusic()
    {
        int i = 0;
        foreach (Music m in _music)
        {
            i++;
            Console.WriteLine($"{i}. {m.DisplayInfo()}");
        }
    }

    public Music GetRandomMusic()
    {
        if (_music.Count == 0)
        {
            Console.WriteLine("You don't have any music yet, please add one:");
            AddMusic();
        }
        
        Random randomSong = new Random();

        Music song = _music[randomSong.Next(_music.Count)];

        return song;
    }

    public void SaveMusicFile()
    {
        Console.Write("Enter the name you want your file saved as: ");
        string filename = Console.ReadLine();
        
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Music m in _music)
        {
            outputFile.WriteLine(m.SaveInfo());
        }
        }
    }

    public void LoadMusicFile(string filename)
    {
        // TODO: load a file and put in lists
    }

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
        int i = 0;

        foreach (Instrument instr in _instruments)
        {
            i++;
            Console.WriteLine($"{i}. {instr.DisplayInstrument()}");
        }
    }

    public void SaveInstruments()
    {
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
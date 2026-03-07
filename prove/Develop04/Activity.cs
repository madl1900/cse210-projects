public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;
    private DateTime _startTime;
    protected DateTime _endTime;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public int StartMessage(string name, string description)
    {
        Console.Clear();

        Console.WriteLine($"Welcome to the {name}.");
        Console.WriteLine();
        Console.WriteLine(description);

        Console.WriteLine();
        Console.Write("How many seconds would you like to do your activity? ");
        string duration = Console.ReadLine();
        _duration = int.Parse(duration);
        
        Console.WriteLine("Prepare to begin the activity");

        Countdown(5);

        return _duration;
    }

    public void EndMessage(string name, int duration)
    {
        Console.Clear();
        Console.WriteLine("Good job!");
        
        Spinner(3);

        Console.WriteLine($"\nYou completed {duration} seconds of the {name}");

        Spinner(5);
    }

    public void GetActivityTime()
    {
        _startTime = DateTime.Now;
        _endTime = _startTime.AddSeconds(_duration);
    }

    public void Spinner(int time)
    {

        DateTime spinStart = DateTime.Now;
        DateTime spinEnd = spinStart.AddSeconds(time);

        Console.Write("|");

        while (DateTime.Now < spinEnd)
        {
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write("/");

            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write("-");

            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write("\\");

            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write("|");
        }
    }

    public void Countdown(int time)
    {
        for (int i = time; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}
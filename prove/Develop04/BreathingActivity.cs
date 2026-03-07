public class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description) : base(name, description)
    {
        
    }
    public void DisplayBreatheMessage()
    {

        StartMessage(_name, _description);

        GetActivityTime();

        while (DateTime.Now < _endTime)
        {
            
            Console.Write("\nBreathe in...");

            Countdown(4);

            Console.Write("\nBreathe out...");

            Countdown(4);

            Console.WriteLine();
        }

        EndMessage(_name, _duration);
    }
}
using System.Formats.Asn1;

public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>();
    private List<string> _listingItems = new List<string>();

    public ListingActivity(string name, string description) : base(name, description)
    {
        _prompts.Add("Who are people that you appreciate?");
        _prompts.Add("What are personal strengths of yours?");
        _prompts.Add("Who are people that you have helped this week?");
        _prompts.Add("When have you felt the Holy Ghost this month?");
        _prompts.Add("Who are some of your personal heroes?");
    }

    public string GetPrompt()
    {
        Random randomNum = new Random();

        string myString = _prompts[randomNum.Next(_prompts.Count)];

        return myString;
    }


    public void GetAnswers()
    {
        Console.Clear();

        StartMessage();

        Console.WriteLine(GetPrompt());

        Countdown(5);

        Console.WriteLine("\nMake your list here:");
        
        GetActivityTime();

        while (DateTime.Now < _endTime)
        {
            string answer = Console.ReadLine();

            _listingItems.Add(answer);
        }

        Console.WriteLine($"\nYou listed {_listingItems.Count} items!");

        Spinner(5);

        EndMessage();
    }
}
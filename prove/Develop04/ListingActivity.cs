using System.Formats.Asn1;

public class ListingActivity : PromptActivity
{

    public ListingActivity(string name, string description) : base(name, description)
    {
        
    }

    public void MakePrompts()
    {
        MakeList("Who are people that you appreciate?", _prompts);
        MakeList("What are personal strengths of yours?", _prompts);
        MakeList("Who are people that you have helped this week?", _prompts);
        MakeList("When have you felt the Holy Ghost this month?", _prompts);
        MakeList("Who are some of your personal heroes?", _prompts);
    }


    public void GetAnswers()
    {
        Console.Clear();

        StartMessage(_name, _description);

        MakePrompts();

        Console.WriteLine(GetListString(_prompts));

        Countdown(5);

        Console.WriteLine("\nMake your list here:");
        
        GetActivityTime();

        while (DateTime.Now < _endTime)
        {
            string answer = Console.ReadLine();

            MakeList(answer, _reflections);
        }

        Console.WriteLine($"\nYou listed {_reflections.Count} items!");

        Spinner(5);

        EndMessage(_name, _duration);
    }
}
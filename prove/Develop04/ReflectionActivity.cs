using System.ComponentModel;

public class ReflectionActivity : Activity
{
    private List<string> _prompts = new List<string>();
    private List<string> _questions = new List<string>();
    private List<string> _unusedQuestions = new List<string>();

    public ReflectionActivity(string name, string description) : base(name, description)
    {
        _prompts.Add("Think of a time when you stood up for someone else.");
        _prompts.Add("Think of a time when you did something really difficult.");
        _prompts.Add("Think of a time when you helped someone in need.");
        _prompts.Add("Think of a time when you did something truly selfless.");

        _questions.Add("Why was this experience meaningful to you?");
        _questions.Add("Have you ever done anything like this before?");
        _questions.Add("How did you get started?");
        _questions.Add("How did you feel when it was complete?");
        _questions.Add("What made this time different than other times when you were not as successful?");
        _questions.Add("What is your favorite thing about this experience?");
        _questions.Add("What could you learn from this experience that applies to other situations?");
        _questions.Add("What did you learn about yourself through this experience?");
        _questions.Add("How can you keep this experience in mind in the future?");

        foreach (string question in _questions)
        {
            _unusedQuestions.Add(question);
        }
    }

    public string GetListString(List<string> myList)
    {
        Random randomNum = new Random();

        string myString = myList[randomNum.Next(myList.Count)];
        
        myList.Remove(myString);

        return myString;
    }

    public void DisplayMessages()
    {
        StartMessage();

        Console.Clear();
        Console.WriteLine(GetListString(_prompts));
        Spinner(5);

        Console.WriteLine("\nNow, reflect on the following questions:");
        Console.WriteLine();

        GetActivityTime();

        while (DateTime.Now < _endTime)
        {
            Console.WriteLine(GetListString(_unusedQuestions));

            Spinner(10);
        }

        EndMessage();
    }
}
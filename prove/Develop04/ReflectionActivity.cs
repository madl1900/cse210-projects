using System.ComponentModel;

public class ReflectionActivity : PromptActivity
{

    public ReflectionActivity(string name, string description) : base(name, description)
    {
        
    }

    public void MakePrompts()
    {
        MakeList("Think of a time when you stood up for someone else.", _prompts);
        MakeList("Think of a time when you did something really difficult.", _prompts);
        MakeList("Think of a time when you helped someone in need.", _prompts);
        MakeList("Think of a time when you did something truly selfless.", _prompts);
    }

    public void MakeQuestions()
    {
        MakeList("Why was this experience meaningful to you?", _reflections);
        MakeList("Have you ever done anything like this before?", _reflections);
        MakeList("How did you get started?", _reflections);
        MakeList("How did you feel when it was complete?", _reflections);
        MakeList("What made this time different than other times when you were not as successful?", _reflections);
        MakeList("What is your favorite thing about this experience?", _reflections);
        MakeList("What could you learn from this experience that applies to other situations?", _reflections);
        MakeList("What did you learn about yourself through this experience?", _reflections);
        MakeList("How can you keep this experience in mind in the future?", _reflections);

        MakeUnusedList(_reflections, _unusedReflections);
    }

    public void DisplayMessages()
    {
        StartMessage(_name, _description);

        MakePrompts();
        MakeQuestions();

        Console.Clear();
        Console.WriteLine(GetListString(_prompts));
        Spinner(5);

        Console.WriteLine("\nNow, reflect on the following questions:");
        Console.WriteLine();

        GetActivityTime();

        while (DateTime.Now < _endTime)
        {
            Console.WriteLine(GetListString(_unusedReflections));

            Spinner(10);
        }

        EndMessage(_name, _duration);
    }
}
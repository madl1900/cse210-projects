public class ImageryActivity : PromptActivity
{

    public ImageryActivity(string name, string description) : base(name, description)
    {
        
    }

    public void MakeImages()
    {
        MakeList("house", _prompts);
        MakeList("animal", _prompts);
        MakeList("flower", _prompts);
        MakeList("painting", _prompts);
        MakeList("car", _prompts);
        MakeList("book", _prompts);
    }

    public void MakeQuestions(string item)
    {
        MakeList($"What color is the {item}?", _reflections);
        MakeList($"How big is the {item}?", _reflections);
        MakeList($"Do you like the {item}?", _reflections);
        MakeList($"What type of {item} is it?", _reflections);
        MakeList($"How do you feel about the {item}?", _reflections);
        MakeList($"Why did you pick this version of the {item}?", _reflections);

        MakeUnusedList(_reflections, _unusedReflections);
    }

    public void DisplayImages()
    {
        StartMessage(_name, _description);

        Console.Clear();

        MakeImages();

        string image = GetListString(_prompts);
        if (image.StartsWith("a") | image.StartsWith("e") | image.StartsWith("i") | image.StartsWith("o") | image.StartsWith("u"))
        {
            Console.WriteLine($"Picture an {image}");
        }
        else
        {
            Console.WriteLine($"Picture a {image}");
        }
        
        MakeQuestions(image);
        
        Spinner(5);

        Console.WriteLine();

        GetActivityTime();

        while (DateTime.Now < _endTime)
        {
            Console.WriteLine(GetListString(_unusedReflections));

            Spinner(5);
        }

        EndMessage(_name, _duration);
    }
}
public class ImageryActivity : Activity
{
    private List<string> _images = new List<string>();
    private List<string> _questions = new List<string>();
    private List<string> _unusedQuestions = new List<string>();
    
    public ImageryActivity(string name, string description) : base(name, description)
    {
        _images.Add("house");
        _images.Add("animal");
        _images.Add("flower");
        _images.Add("painting");
        _images.Add("car");
        _images.Add("book");
    }

    public void MakeQuestions(string item)
    {
        _questions.Add($"What color is the {item}?");
        _questions.Add($"How big is the {item}?");
        _questions.Add($"Do you like the {item}?");
        _questions.Add($"What type of {item} is it?");
        _questions.Add($"How do you feel about the {item}?");
        _questions.Add($"Why did you pick this version of the {item}?");
        _questions.Add($"Would you want to have this {item} in real life?");
        _questions.Add($"How heavy is the {item}");
        _questions.Add($"Where is the {item}?");

    }

    public string GetListString(List<string> myList)
    {
        Random randomNum = new Random();

        string myString = myList[randomNum.Next(myList.Count)];
        
        myList.Remove(myString);

        return myString;
    }

    public void DisplayImages()
    {
        StartMessage();

        Console.Clear();

        string image = GetListString(_images);
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
            Console.WriteLine(GetListString(_questions));

            Spinner(5);
        }

        EndMessage();
    }
}
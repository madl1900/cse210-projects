public class PromptActivity : Activity
{
    protected List<string> _prompts = new List<string>();
    protected List<string> _reflections = new List<string>();
    protected List<string> _unusedReflections = new List<string>();


    public PromptActivity(string name, string description) : base(name, description)
    {
        
    }
    public void MakeList(string listString, List<string> myList)
    {
        myList.Add(listString);
    }

    public void MakeUnusedList(List<string> ogList, List<string> unusedList)
    {
        foreach (string listString in ogList)
        {
            MakeList(listString, unusedList);
        }
    }

    public string GetListString(List<string> myList)
    {
        Random randomNum = new Random();

        string myString = myList[randomNum.Next(myList.Count)];
        
        myList.Remove(myString);

        return myString;
    }
}
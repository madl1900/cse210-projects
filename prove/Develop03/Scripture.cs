using System.Globalization;

public class Scripture
{
    private string _verse;
    private List<Word> _words = new List<Word>();
    private Reference _reference = new Reference();

    public Scripture(Reference reference, string verse)
    {
        _reference = reference;
        _verse = verse;
        _words = GetWordList();
    }

    private List<Word> GetWordList()
    {
        List<string> stringList = new List<string>();
        stringList = _verse.Split(' ').ToList();

        foreach (string word in stringList)
        {
            _words.Add(new Word(word));
        }
        return _words;
    }

    private void DisplayScripture()
    {

        _reference.DisplayReference();
        foreach (Word verseWord in _words)
        {
            Console.Write($"{verseWord.GetWord()} ");
        }
        HideVerseWords();
    }

    private void HideVerseWords()
    {
        Random randomNum = new Random();
        List<Word> notHiddenWords = new List<Word>();

        foreach (Word verseWord in _words)
        {
            if (!verseWord.GetIsHidden())
            {
                notHiddenWords.Add(verseWord);
            }
        }   

        if (notHiddenWords.Count != 0)
            for (int num = 0; num < notHiddenWords.Count && num < 4; num++)
            {
                int indexNum = randomNum.Next(notHiddenWords.Count);
                notHiddenWords[indexNum].HideWord();
                notHiddenWords.Remove(notHiddenWords[indexNum]);
            }
    }
    
    public void Run()
    {
        string userChoice = "";
        
        
        while (userChoice != "quit")
        {
            int hiddenCount = 0;

            foreach (Word word in _words)
            {
                if (word.GetIsHidden())
                {
                    hiddenCount++;
                }
            }

            Console.Clear();
            DisplayScripture();

            if (hiddenCount == _words.Count)
            {
                break;
            }
            else
            {
                Console.WriteLine();
                Console.Write("Press enter to hide words, or type quit to end. ");
                userChoice = Console.ReadLine();
            }
        }
        
    }
}
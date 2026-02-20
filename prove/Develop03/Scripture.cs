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
        _words = GetWordList(_verse, _words);
    }

    private List<Word> GetWordList(string verse, List<Word> words)
    {
        List<string> stringList = new List<string>();
        stringList = verse.Split(' ').ToList();

        foreach (string word in stringList)
        {
            words.Add(new Word(word));
        }
        return words;
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
                CheckMemory();
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
    
    public void CheckMemory()
    {   
        string tryAgain = "";
        
        while (tryAgain != "N")
        {   
            Console.WriteLine();
            Console.WriteLine("Test your memory! \nType the whole verse and see how many words you get right. \nHint: Don't forget about punctuation!");

            string userVerse = Console.ReadLine();
            List<Word> userWords = new List<Word>();
            userWords = GetWordList(userVerse, userWords);
            int correctCount = 0;
            int index = 0;

            if (userWords.Count == _words.Count)
            {
                Console.Clear();
                foreach (Word userWord in userWords)
                {
                    _words[index].UnhideWord();

                    if (userWord.GetWord() == _words[index].GetWord())
                    {
                        Console.Write($"{_words[index].GetWord()} ");
                        _words[index].HideWord();
                        correctCount++;
                    }
                    else
                    {
                        _words[index].HideWord();
                        Console.Write($"{_words[index].GetWord()} ");
                    }
            
                    index++;
                }

                Console.WriteLine($"\nYou got {correctCount} out of {_words.Count} words correct.");

                if (correctCount == _words.Count)
                {
                    Console.Write($"Congratulations! You memorized the scripture: ");
                    _reference.DisplayReference();
                    break;
                }
            }  
            else if (userWords.Count > _words.Count)
            {
                Console.WriteLine("\nThat is too many words");
            }
            else
            {
                Console.WriteLine("\nThat is not enough words");
            }

            Console.Write("\nWould you like to try again (Y/N)? ");
            tryAgain = Console.ReadLine();
            Console.Clear();
        }
    }
}
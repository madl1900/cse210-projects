public class Reference
{
    private string _book;
    private int _chapter;
    private int _verseNum1;
    private int _verseNum2;
    private string _verseString;

    public Reference()
    {
        _book = "";
        _chapter = 0;
        _verseNum1 = 0;
        _verseNum2 = 0;
    }
    public Reference(string book, int chapter, int verseNum1)
    {
        _book = book;
        _chapter = chapter;
        _verseNum1 = verseNum1;
        _verseNum2 = 0;
    }

    public Reference(string book, int chapter, int verseNum1, int verseNum2)
    {
       _book = book;
        _chapter = chapter;
        _verseNum1 = verseNum1;
        _verseNum2 = verseNum2; 
    }

    private void GetVerseString(int verseNum1, int verseNum2)
    {
        if (verseNum2 == 0)
        {
            _verseString = verseNum1.ToString();
        }
        else
        {
            _verseString = $"{verseNum1}-{verseNum2}";
        }
    }

    public void DisplayReference()
    {
        GetVerseString(_verseNum1, _verseNum2);
        Console.WriteLine($"{_book} {_chapter}:{_verseString}");
    }

}
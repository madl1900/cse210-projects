public class Word
{
    private string _word;
    private bool _isHidden = false;
    private string _hiddenWord;

    public Word(string word)
    {
        _word = word;
    }

    public bool GetIsHidden()
    {
        return _isHidden;
    }
    
    public void HideWord()
    {
      _isHidden = true;  
    }

    public void UnhideWord()
    {
        _isHidden = false;
    }
    public string GetWord()
    {
        if (_isHidden)
        {
            _hiddenWord = new string('_', _word.Length);
            return _hiddenWord;
        }
        else
        {
            return _word;
        }
    }
}
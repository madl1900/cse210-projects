public class Music
{
    protected string _name;
    protected int _tempo;
    protected string _timeSignature;

    public Music(string name, int tempo, string timeSignature)
    {
        _name = name;
        _tempo = tempo;
        _timeSignature = timeSignature;
    }

    public virtual void DisplayInfo()
    {
        // TODO: set default to display music info
    }

    public int GetTempo()
    {
        return _tempo;
    }

    public string GetTimeSignature()
    {
        return _timeSignature;
    }
}
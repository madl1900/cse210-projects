public class Metronome
{
    private int _tempo;
    private int _duration;
    private string _timeSignature;

    public Metronome(int duration)
    {
        duration = _duration;
        _tempo = 88;
        _timeSignature = "4/4";
    }
    public Metronome(int tempo, string timeSignature, int duration)
    {
        _tempo = tempo;
        _timeSignature = timeSignature;
        _duration = duration;
    }

    public void SetTempo(int tempo)
    {
        _tempo = tempo;
    }

    public void SetTimeSignature(string timeSignature)
    {
        _timeSignature = timeSignature;
    }

    public void Run()
    {
        // TODO: run metronome
    }
}
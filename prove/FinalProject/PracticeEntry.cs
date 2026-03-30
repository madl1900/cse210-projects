using System.Diagnostics.Metrics;

public class PracticeEntry
{
    private Instrument _instrument;
    private MusicPiece _song;
    private MusicScale _scale;
    private int _duration;
    private DateTime _date = new DateTime();

    public PracticeEntry(Instrument instrument, MusicPiece song, MusicScale scale, int duration)
    {
        _instrument = instrument;
        _song = song;
        _scale = scale;
        _duration = duration;
        _date = DateTime.Now();
    }

    public void DisplayPracticeInfo()
    {
        // TODO: layout how to display a practice entry
    }
}
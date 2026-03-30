using System.Diagnostics.Metrics;

public class MusicPiece : Music
{
    private int _measureNum;
    private Instrument _instrument;
    private string _difficulty;
    private string _composer;
    private string _keySignature;

    public MusicPiece(string name, int tempo, string timeSignature, int measureNum, Instrument instrument, string difficulty, string composer, string keySignature) : base(name, tempo, timeSignature)
    {
        _measureNum = measureNum;
        _instrument = instrument;
        _difficulty = difficulty;
        _composer = composer;
        _keySignature = keySignature;
    }

    public override void DisplayInfo()
    {
        // TODO: display piece info
    }
}
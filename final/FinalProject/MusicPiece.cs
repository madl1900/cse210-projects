public class MusicPiece : Music
{
    private Instrument _instrument;
    private string _composer;
    private string _keySignature;

    public MusicPiece(string name, int tempo, string timeSignature, Instrument instrument, string composer, string keySignature) : base(name, tempo, timeSignature)
    {
        _instrument = instrument;
        _composer = composer;
        _keySignature = keySignature;
    }

    public override string DisplayInfo()
    {
        return $"Song: {_name} Composer: {_composer} Instrument: {_instrument.DisplayInstrument()}";
    }

    public override string SaveInfo()
    {
        return $"MusicPiece, {_name}, {_tempo}, {_timeSignature}, {_keySignature}, {_composer}|{_instrument.SaveInstrument()}";
    }
}
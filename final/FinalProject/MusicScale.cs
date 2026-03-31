public class MusicScale : Music
{
    private string _rhythm;

    public MusicScale(string name, int tempo, string timeSignature) : base(name, tempo, timeSignature)
    {
        _rhythm = "quarter notes";
    }
    public MusicScale(string name, int tempo, string timeSignature, string rhythm) : base(name, tempo, timeSignature)
    {
        _rhythm = rhythm;
    }

    public void SetRhythm(string rhythm)
    {
        _rhythm = rhythm;
    }

    public override void DisplayInfo()
    {
        // TODO: display scale info
    }
}
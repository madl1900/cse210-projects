using System.ComponentModel.DataAnnotations;

public class Instrument
{
    private string _name;
    private string _type;

    public Instrument(string name, string type)
    {
        _name = name;
        _type = type;
    }

    public void DisplayInstrument()
    {
        // TODO: Display instrument details
    }
}
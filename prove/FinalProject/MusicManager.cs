public class MusicManager
{
    private List<MusicPiece> _songs = new List<MusicPiece>();
    private List<MusicScale> _scales = new List<MusicScale>();

    public void AddMusic(MusicManager music, List<Music> musicList)
    {
        // add music to the list of music
    }

    public void DisplayMusic(List<Music> musicList)
    {
        // Display everything in a list
    }

    public Music GetRandomMusic(List<Music> musicList)
    {
        // TODO: return a random piece of music from the list
    }

    public void SaveMusicFile(string filename)
    {
        // TODO: save lists of music to a file
    }

    public void LoadMusicFile(string filename)
    {
        // TODO: load a file and put in lists
    }

}
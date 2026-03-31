public class MusicManager
{
    private List<MusicPiece> _songs = new List<MusicPiece>();
    private List<MusicScale> _scales = new List<MusicScale>();

    public void AddMusic(MusicManager music, string type)
    {
        // add music to the corresponding type of music list
    }

    public void DisplayMusic()
    {
        // Display everything in both lists
    }

    public void GetRandomMusic(List<Music> musicList)
    {
        // TODO: RETURN a random piece of music from the list
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
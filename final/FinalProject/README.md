---

```md
# Practice Room Program

This program was created to help musicians track their music and practices. It has nested menus for the practice log, music manager, and metronome, which are all interconnected so that you can use the music and instruments in the music manager within the practice log and metronome. 

The metronome is a visual one, which shows the beats based on the inputted tempo and time signature.

For the music, there are two types:MusicPiece (representing a song), and MusicScale (representing a scale).

The Instrument class is used within MusicPiece, MusicManager, and PracticeEntry, as each song and each practice entry require a specific instrument.

The MusicManager class manages all songs, scales, and instruments so they can be used in practice entries and the 
metronome.

The PracticeLog class manages all practice entries.
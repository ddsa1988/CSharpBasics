namespace UsingAPI.Models;

public class SongFilter {
    public static void ByGenre(List<Song> songs) {
        IEnumerable<string> genres = songs.Select((song => song.Genre)).Distinct();

        PrintCollection.Print(genres, "");
    }

    public static void OrderByName(List<Song> songs) {
        List<Song> songsOrdered = songs.OrderBy((song => song.Artist)).ToList();

        PrintCollection.Print(songsOrdered, "\n");
    }

    public static void ArtistByGenre(List<Song> songs, string genre) {
        List<Song> songsOrdered = songs.Where((song => song.Genre == genre)).ToList();

        PrintCollection.Print(songsOrdered, "\n");
    }

    public static void ByArtistName(List<Song> songs, string artist) {
        List<Song> songsOrdered = songs.Where((song => song.Artist == artist)).ToList();

        PrintCollection.Print(songsOrdered, "\n");
    }
}
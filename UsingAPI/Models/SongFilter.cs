namespace UsingAPI.Models;

public class SongFilter {
    public static void ByGenre(List<Song> songs) {
        IEnumerable<string> genres = songs.Select((song => song.Genre)).Distinct();

        PrintCollection.Print(genres, "");
    }

    public static void ByArtist(List<Song> songs) {
        IEnumerable<string> artists = songs.OrderBy((song => song.Artist)).Select((song => song.Artist)).Distinct();

        PrintCollection.Print(artists, "");
    }

    public static void ArtistByGenre(List<Song> songs, string genre) {
        IEnumerable<string> artists =
            songs.Where((song => song.Genre.Contains(genre))).Select((song => song.Artist)).Distinct();

        PrintCollection.Print(artists, "");
    }

    public static void SongByArtistName(List<Song> songs, string artist) {
        IEnumerable<string> songsOrdered =
            songs.Where((song => song.Artist.Contains(artist))).Select((song => song.Name)).Distinct();

        PrintCollection.Print(songsOrdered, "");
    }
}
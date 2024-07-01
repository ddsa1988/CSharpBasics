using UsingAPI.Models;

namespace UsingAPI.Examples;

public class Example006 {
    public static void UserMain() {
        FavoriteSongs favorite = new FavoriteSongs("Diego");

        favorite.AddSong(new Song(){Name = "Phantomlord", Artist = "Metallica", Genre = "Rock", Duration = 1000});
        favorite.AddSong(new Song(){Name = "Blood Angel", Artist = "Avatar", Genre = "Rock", Duration = 5000});

        Console.WriteLine(favorite);
    }
}
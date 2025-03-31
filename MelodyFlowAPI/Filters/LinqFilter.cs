using MelodyFlowAPI.Models;

namespace MelodyFlowAPI.Filters;

internal class LinqFilter
{
    public static void FilterEveryMusicalGenre(List<Song> songs)
    {
        var everyMusicalGenre = songs.Select(genres => genres.Genre).Distinct().ToList();
        Console.WriteLine("List of Genres\n");
        foreach (var genre in everyMusicalGenre)
        {
            Console.WriteLine($"- {genre}");
        }
    }

    public static void FilterArtistsByMusicalGenre(List<Song> songs, string genre)
    {
        var artistByMusicalGenre = songs.Where(song => song.Genre!.Contains(genre)).Select(song => song.Artist).Distinct().ToList();
        Console.WriteLine($"List of Artists based on the Genre: {genre}\n");
        foreach (var artist in artistByMusicalGenre)
        {
            Console.WriteLine($"- {artist}");
        }
    }

    public static void FilterSongsOfAnArtist(List<Song> songs, string artistName)
    {
        var artistSongs = songs.Where(songs => songs.Artist!.Equals(artistName)).ToList();
        Console.WriteLine($"{artistName}'s Songs");
        foreach(var song in artistSongs)
        {
            Console.WriteLine($"- {song.Name}");
        }
    }

    public static void FilterSongsByYear(List<Song> songs, int year)
    {
       var songsByYear = songs.Where(song => song.Year == year)
            .OrderBy(songs => songs.Name)
            .Select(songs => songs.Name)
            .Distinct()
            .ToList();
        Console.WriteLine($"{year}'s Songs");
        foreach (var song in songsByYear)
        {
            Console.WriteLine($"- {song}");
        }
    }
}

using MelodyFlowAPI.Filters;
using MelodyFlowAPI.Models;
using System.Text.Json;

// Using HTTP API to get the songs
using (HttpClient client = new HttpClient())
{
    // Tries to request the songs from the API
    try
    {
        string response = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        var songs = JsonSerializer.Deserialize<List<Song>>(response)!;
        
        //songs[1].DisplaySongDetails();
        //LinqFilter.FilterEveryMusicalGenre(songs);
        //LinqOrder.DisplayOrderedArtistsList(songs);
        //LinqFilter.FilterArtistsByMusicalGenre(songs, "pop");
        //LinqFilter.FilterSongsOfAnArtist(songs, "Michael Jackson");
        //LinqFilter.FilterSongsByYear(songs, 2000);
        LinqFilter.FilterSongsByKey(songs, "C#");

        var cesarsFavoriteSongs = new FavoriteSongs("Cesar");
        cesarsFavoriteSongs.AddFavoriteSong(songs[1]);
        cesarsFavoriteSongs.AddFavoriteSong(songs[20]);
        cesarsFavoriteSongs.AddFavoriteSong(songs[31]);
        cesarsFavoriteSongs.AddFavoriteSong(songs[35]);
        cesarsFavoriteSongs.AddFavoriteSong(songs[80]);

        //cesarsFavoriteSongs.DisplayFavoriteSongs();

        //cesarsFavoriteSongs.GenerateJsonFile();
        //cesarsFavoriteSongs.GenerateTxtFile();

    }
    // If it doen't succeed, displays the error
    catch (Exception error) 
    {
        Console.WriteLine($"Error: {error}");
    }
}

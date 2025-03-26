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
        songs[1998].DisplaySongDetails();
    }
    // If it doen't succeed, displays the error
    catch (Exception error) 
    {
        Console.WriteLine($"Error: {error}");
    }
}

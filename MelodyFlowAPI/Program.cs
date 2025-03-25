// Using HTTP API to get the songs
using (HttpClient client = new HttpClient())
{
    // Tries to request the songs from the API
    try
    {
        string response = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        Console.WriteLine(response);
    }
    // If it doen't succeed, displays the error
    catch (Exception error) 
    {
        Console.WriteLine($"Error: {error}");
    }
}

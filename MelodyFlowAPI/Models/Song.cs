using System.Text.Json.Serialization;

namespace MelodyFlowAPI.Models;

internal class Song
{
    private string[] keys = { "C", "C#", "D", "Eb", "E", "F", "F#", "G", "Ab", "A", "Bb", "B" };

    [JsonPropertyName("artist")]
    public string? Artist { get; set; }

    [JsonPropertyName("song")]
    public string? Name { get; set; }

    [JsonPropertyName("duration_ms")]
    public int Duration { get; set; }

    [JsonPropertyName("explicit")]
    public string? Explicit { get; set; }

    [JsonPropertyName("year")]
    public string? YearString { get; set; }

    public int Year 
    { 
        get 
        { 
            return int.Parse(YearString!);
        } 
    }

    [JsonPropertyName("genre")]
    public string? Genre { get; set; }

    [JsonPropertyName("key")]
    public int Key { get; set; }

    public string Tone 
    {
        get
        {
            return keys[Key];
        }
    }



    public void DisplaySongDetails()
    {
        Console.WriteLine($"Artist: {Artist}");
        Console.WriteLine($"Song: {Name}");
        Console.WriteLine($"Duration in Seconds: {Duration / 1000}");
        var explicitContent = Explicit == "True" ? "Yes" : "No";
        Console.WriteLine($"Contains Explicit Content: {explicitContent}");
        Console.WriteLine($"Published in: {YearString}");
        Console.WriteLine($"Genre: {Genre}");
        Console.WriteLine($"Key of the Song: {Tone}");
    }
}

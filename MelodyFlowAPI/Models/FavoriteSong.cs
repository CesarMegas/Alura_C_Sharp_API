using System.Text.Json;
namespace MelodyFlowAPI.Models;

internal class FavoriteSongs
{
    public FavoriteSongs(string name)
    {
        Name = name;
        FavoriteSongsList = new List<Song>();
    }

    public string? Name { get; set; }
    public List<Song> FavoriteSongsList { get; set; }

    public void AddFavoriteSong(Song song)
    {
        FavoriteSongsList.Add(song);
    }
    
    public void DisplayFavoriteSongs()
    {
        Console.WriteLine($"{Name}'s Favorite Songs");
        foreach (var song in FavoriteSongsList)
        {
            Console.WriteLine($"- {song.Name}, from {song.Artist}.");
        }
        Console.WriteLine();
    }

    public void GenerateJsonFile()
    {
        string json = JsonSerializer.Serialize(new 
        {
            name = Name,
            songs = FavoriteSongsList
        });

        string fileName = $"{Name}s-favorite-songs.json";

        File.WriteAllText(fileName, json);
        Console.WriteLine($"Json File Successfully Created! {Path.GetFullPath(fileName)}");
    }

    public void GenerateTxtFile()
    {
        string fileName = $"{Name}s-favorite-songs.txt";
        using (StreamWriter arquivo = new StreamWriter(fileName))
        {
            arquivo.WriteLine($"Músicas favoritas do {Name}\n");
            foreach (var musica in FavoriteSongsList)
            {
                arquivo.WriteLine($"- {musica.Name}");
            }
        }
        Console.WriteLine($"TXT File Successfully Created! {Path.GetFullPath(fileName)}");
    }
}


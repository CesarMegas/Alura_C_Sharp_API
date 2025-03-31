using MelodyFlowAPI.Models;

namespace MelodyFlowAPI.Filters;

internal class LinqOrder
{
    public static void DisplayOrderedArtistsList(List<Song> songs)
    {
        var orderedArtists = songs.OrderBy(song => song.Artist).Select(song => song.Artist).Distinct().ToList();
        Console.WriteLine("Ordered Artists List");
        foreach (var artist in orderedArtists) 
        {
            Console.WriteLine($"- {artist}");
        }
    }
}

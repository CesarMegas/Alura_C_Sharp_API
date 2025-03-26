using System.Text.Json.Serialization;

namespace Atividade02.Modelos;

internal class Carro
{
    [JsonPropertyName("marca")]
    public string? Marca { get; set; }

    [JsonPropertyName("modelo")]
    public string? Modelo { get; set; }

    [JsonPropertyName("ano")]
    public int Ano { get; set; }

    [JsonPropertyName("tipo")]
    public string? Tipo { get; set; }

    [JsonPropertyName("motor")]
    public string? Motor { get; set; }

    public void ExibirDetalhesDoCarro() 
    {
        Console.WriteLine($"Marca: {Marca}");
        Console.WriteLine($"Modelo: {Modelo}");
        Console.WriteLine($"Ano: {Ano}");
        Console.WriteLine($"Tipo: {Tipo}");
        Console.WriteLine($"Motor: {Motor}\n");

    }
}

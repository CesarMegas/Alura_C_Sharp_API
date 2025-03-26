using System.Text.Json.Serialization;

namespace Atividade02.Modelos;

internal class Pais
{
    [JsonPropertyName("nome")]
    public string Nome { get; set; }

    [JsonPropertyName("capital")]
    public string Capital { get; set; }

    [JsonPropertyName("populacao")]
    public int Populacao { get; set; }

    [JsonPropertyName("continente")]
    public string Continente { get; set; }

    [JsonPropertyName("idioma")]
    public string Idioma { get; set; }

    public void ExibirDetalhesDoPais()
    {
        Console.WriteLine($"Nome do País: {Nome}");
        Console.WriteLine($"Capital do País: {Capital}");
        Console.WriteLine($"População Total: {Populacao} pessoas");
        Console.WriteLine($"Continente: {Continente}");
        Console.WriteLine($"Idioma: {Idioma}");
    }
}

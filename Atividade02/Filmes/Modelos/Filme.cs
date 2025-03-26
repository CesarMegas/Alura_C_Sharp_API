using System.Text.Json.Serialization;

namespace Atividade02.Modelos;

internal class Filme
{
    [JsonPropertyName("image")]
    public string? UrlDaImagem { get; set; }

    [JsonPropertyName("fullTitle")]
    public string? TituloCompleto { get; set; }

    [JsonPropertyName("crew")]
    public string? Equipe { get; set; }

    [JsonPropertyName("rank")]
    public string? Rank { get; set; }

    [JsonPropertyName("imDbRating")]
    public string? NotaImDb { get; set; }

    [JsonPropertyName("imDbRatingCount")]
    public string? VotosImDb { get; set; }

    public void ExibirDetalhesDoFilme()
    {
        //Exibe a Imagem no Navegador
        System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
        {
            FileName = UrlDaImagem,
            UseShellExecute = true
        });

        //Exibe os Detalhes no Console
        Console.WriteLine($"\nFilme: {TituloCompleto}");
        Console.WriteLine($"Participações: {Equipe}");
        Console.WriteLine($"Nota: {NotaImDb} (de {VotosImDb} votos)");
        Console.WriteLine($"Posição no Ranking: {Rank}");
    }
}

using System.Text.Json.Serialization;

namespace Atividade02.Modelos;

internal class Livro
{
    [JsonPropertyName("titulo")]
    public string? Titulo { get; set; }

    [JsonPropertyName("autor")]
    public string? Autor { get; set; }

    [JsonPropertyName("ano_publicacao")]
    public int AnoDePublicacao { get; set; }

    [JsonPropertyName("genero")]
    public string? Genero { get; set; }

    [JsonPropertyName("paginas")]
    public int Paginas { get; set; }

    [JsonPropertyName("editora")]
    public string? Editora { get; set; }

    public void ExibirDetalhesDoLivro()
    {
        Console.WriteLine($"Nome do Livro: {Titulo} ({Paginas} páginas)");
        Console.WriteLine($"Escrito por: {Autor}");
        Console.WriteLine($"Publicado em: {AnoDePublicacao}");
        Console.WriteLine($"Gênero: {Genero}");
        Console.WriteLine($"Editora: {Editora}\n");

    }
}

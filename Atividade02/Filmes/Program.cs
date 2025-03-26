using Atividade02.Modelos;
using System.Text.Json;

using (HttpClient client1 = new HttpClient())
{
    try
    {
        string resposta = await client1.GetStringAsync("https://raw.githubusercontent.com/ArthurOcFernandes/Exerc-cios-C-/curso-4-aula-2/Jsons/TopMovies.json");
        var filmes = JsonSerializer.Deserialize < List<Filme>>(resposta)!;
        Console.WriteLine($"Quantidade Total de Filmes: {filmes.Count}\n");
        filmes[1].ExibirDetalhesDoFilme();
    }
    catch (Exception error)
    {
        Console.WriteLine($"Error: {error}");
    }
}

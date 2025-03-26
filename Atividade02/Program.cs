// Atividade 02 - Linq e Ordenação
// Exercício 01 - Modelar e desserializar a classe Filme, que pode ser encontrada no endpoint disponibilizado

// Exercício 02 - Modelar e desserializar a classe Pais, que pode ser encontrada no endpoint disponibilizado

// Exercício 03 - Modelar e desserializar a classe Carro, que pode ser encontrada no endpoint disponibilizado

// Exercício 04 - Modelar e desserializar a classe Livro, que pode ser encontrada no endpoint disponibilizado

using Atividade02.Modelos;
using System.Text.Json;

// Resolução do Exercício 01
using (HttpClient client1 = new HttpClient())
{
    try
    {
        string resposta = await client1.GetStringAsync("https://raw.githubusercontent.com/ArthurOcFernandes/Exerc-cios-C-/curso-4-aula-2/Jsons/TopMovies.json");
        var filmes = JsonSerializer.Deserialize<List<Filme>>(resposta)!;
        Console.WriteLine($"Quantidade Total de Filmes: {filmes.Count}\n");
        filmes[1].ExibirDetalhesDoFilme();
    }
    catch (Exception error)
    {
        Console.WriteLine($"Error: {error}");
    }
}

Console.WriteLine("==============================\n");

// Resolução do Exercício 02
using (HttpClient client2 = new HttpClient())
{
    try
    {
        string resposta = await client2.GetStringAsync("https://raw.githubusercontent.com/ArthurOcFernandes/Exerc-cios-C-/curso-4-aula-2/Jsons/Paises.json");
        var paises = JsonSerializer.Deserialize<List<Pais>>(resposta)!;
        Console.WriteLine($"Quantidade Total de Países: {paises.Count}\n");
        foreach (var pais in paises)
        {
            pais.ExibirDetalhesDoPais();
        }

    }
    catch (Exception error)
    {
        Console.WriteLine($"Error: {error}");
    }
}

Console.WriteLine("==============================\n");

// Resolução do Exercício 03
using (HttpClient client3 = new HttpClient())
{
    try
    {
        string resposta = await client3.GetStringAsync("https://raw.githubusercontent.com/ArthurOcFernandes/Exerc-cios-C-/curso-4-aula-2/Jsons/Carros.json");
        var carros = JsonSerializer.Deserialize<List<Carro>>(resposta)!;
        Console.WriteLine($"Quantidade Total de Carros: {carros.Count}\n");
        foreach(var carro in carros)
        {
            carro.ExibirDetalhesDoCarro();
        }
    }
    catch (Exception error)
    {
        Console.WriteLine($"Error: {error}");
    }
}

Console.WriteLine("==============================\n");

//Resolução do Exercício 04
using (HttpClient client4 = new HttpClient())
{
    try
    {
        string resposta = await client4.GetStringAsync("https://raw.githubusercontent.com/ArthurOcFernandes/Exerc-cios-C-/curso-4-aula-2/Jsons/Livros.json");
        var livros = JsonSerializer.Deserialize<List<Livro>>(resposta)!;
        Console.WriteLine($"Quantidade Total de Livros: {livros.Count}\n");
        foreach (var livro in livros)
        {
            livro.ExibirDetalhesDoLivro();
        }
    }
    catch (Exception error)
    {
        Console.WriteLine($"Error: {error}");
    }
}

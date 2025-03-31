// Atividade 03 - LINQ
// Exercício 01 - Dada uma lista de números, criar uma consulta LINQ para retornar apenas os elementos únicos da lista.

// Exercício 02 - Dada uma lista de livros com título, autor e ano de publicação, criar uma consulta LINQ para retornar uma lista com os títulos dos livros publicados após o ano 2000, ordenados alfabeticamente.

// Exercício 03 - Dada uma lista de produtos com nome e preço, criar uma consulta LINQ para calcular o preço médio dos produtos.

// Exercíco 04 - Dada uma lista de inteiros, criar uma consulta LINQ para retornar apenas os números pares.

// Resolução do Exercício 01
using Atividade03.Livros;
using Atividade03.Produtos;

List<int> numeros = new List<int> { 1, 2, 2, 3, 3, 3, 4, 4, 4, 4, 5, 5, 5, 5, 5, 6, 6, 6, 6, 7, 7, 7, 8, 8, 9};

var numerosUnicos = numeros.Distinct();

Console.WriteLine("Lista de Números Únicos\n");
foreach (var numero in numerosUnicos)
{    
    Console.Write($"{numero} ");
}

Console.WriteLine("\n\n========================\n");

// Resolução do Exercício 02
List<Livro> livros = new List<Livro>
{
    new Livro {Nome = "Harry Potter e a Pedra Filosofal", Autor = "J. K. Rowling", AnoDePublicacao = 1997 },
    new Livro {Nome = "Harry Potter e a Câmara Secreta", Autor = "J. K. Rowling", AnoDePublicacao = 1998 },
    new Livro {Nome = "Harry Potter e o Prisioneiro de Askaban", Autor = "J. K. Rowling", AnoDePublicacao = 1999 },
    new Livro {Nome = "Harry Potter e o Cálice de Fogo", Autor = "J. K. Rowling", AnoDePublicacao = 2000 },
    new Livro {Nome = "Harry Potter e a Ordem da Fênix", Autor = "J. K. Rowling", AnoDePublicacao = 2003 },
    new Livro {Nome = "Harry Potter e o Enigma do Príncipe", Autor = "J. K. Rowling", AnoDePublicacao = 2005 },
    new Livro {Nome = "Harry Potter e as Relíquias da Morte", Autor = "J. K. Rowling", AnoDePublicacao = 2007 }
};

var livrosSelecionados = livros.
    Where(livro => livro.AnoDePublicacao >= 2000).
    OrderBy(livro => livro.Nome).
    Select(livro => livro.Nome);

Console.WriteLine("Lista de Livros Publicados a partir dos Anos 2000, Ordenados Alfabéticamente\n");
foreach (var livro in livrosSelecionados)
{
    Console.WriteLine(livro);
}

Console.WriteLine("\n========================\n");

// Resolução do Exercício 03
List<Produto> produtos = new List<Produto>
{
    new Produto {Nome = "Placa de Vídeo", Preco = 3700},
    new Produto { Nome = "Laptop", Preco = 1200 },
    new Produto { Nome = "Smartphone", Preco = 800 },
    new Produto { Nome = "Tablet", Preco = 500 },
    new Produto { Nome = "Câmera", Preco = 300 }
};

var precoMedio = produtos.Average(p => p.Preco);

Console.WriteLine($"Preço Médio dos Produtos: {precoMedio}\n");

Console.WriteLine("\n========================\n");

// Resolução do Exercício 04
List<int> listaDeNumeros = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

var numerosPares = listaDeNumeros.Where(x => x % 2 == 0);

Console.WriteLine("Números Pares:\n");
foreach (var numero in numerosPares)
{
    Console.Write($"{numero} ");
}

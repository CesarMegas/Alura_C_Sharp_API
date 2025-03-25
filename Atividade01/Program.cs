// Atividade 01 - Integrando uma API Externa
// Exercício 01 - Escrever um programa que faça uma requisição para a API de games CheapShark e mostre na tela a lista de promoções cadastrada na ferramenta (Você pode utilizar o endpoint: https://www.cheapshark.com/api/1.0/deals).

// Exercício 02 - Escrever um programa que solicite dois números a e b lidos do teclado e realize a divisão de a por b. Caso essa operação não seja possível, mostrar uma mensagem no console que deixe claro o erro ocorrido.

// Exercíco 03 - Declarar uma lista de inteiros e tente acessar um elemento em um índice inexistente. Tratar a exceção apropriada.

// Exercício 04 - Criar uma classe simples com um método e chame esse método em um objeto nulo. Tratar a exceção de método em objeto nulo.

using Atividade01.Classes;

// Resolução do Exercício 01
using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://www.cheapshark.com/api/1.0/deals");
        Console.WriteLine(resposta);
    }
    catch (Exception error) 
    {
        Console.WriteLine($"Error: {error}");
    }
}

// Resolução do Exercício 02
Console.WriteLine("\nDigite o primeiro número: ");
string primeiroValor = Console.ReadLine()!;
int primeiroValorNumerico = int.Parse(primeiroValor);

Console.WriteLine("\nDigite o segundo número: ");
string segundoValor = Console.ReadLine()!;
int segundoValorNumerico = int.Parse(segundoValor);

try
{
    int divisao = primeiroValorNumerico / segundoValorNumerico;
    Console.WriteLine($"\nO resultado da divisão de {primeiroValor} por {segundoValor} é: {divisao}\n");
}
catch (Exception error)
{
    Console.WriteLine($"Error: {error}\n");
}

// Resolução do Exercício 03
List<int> listaDeInteiros = new();
listaDeInteiros.Add(0);
listaDeInteiros.Add(1);
listaDeInteiros.Add(2);
listaDeInteiros.Add(3);

try
{
    Console.WriteLine(listaDeInteiros[5]);
}
catch (Exception error)
{
    Console.WriteLine($"Error: {error}\n");
}

// Resolução do Exercício 04
Jogo jogo = null;

try 
{
    jogo.MostrarNome(); 
}
catch (Exception error)
{
    Console.WriteLine($"Error: {error}");
}

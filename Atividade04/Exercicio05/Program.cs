// Exercício 05 - Criar um programa que lê um arquivo JSON contendo informações de várias pessoas, permite ao usuário inserir uma idade e exibe as pessoas com aquela idade.

using Atividade04.Modelos;
using System.Text.Json;

string fileName = "pessoas.json";

if (File.Exists(fileName))
{
    string jsonString = File.ReadAllText(fileName);

    List<GerarPessoa> pessoas = JsonSerializer.Deserialize<List<GerarPessoa>>(jsonString);

    Console.Write("Digite a Idade para Buscar as Pessoas: ");
    int idadeParaBuscar = int.Parse(Console.ReadLine());

    List<GerarPessoa> pessoasComIdade = pessoas.Where(p => p.Idade == idadeParaBuscar).ToList();

    if (pessoasComIdade.Any())
    {
        Console.WriteLine($"Pessoas com {idadeParaBuscar} Anos:");

        foreach (GerarPessoa pessoa in pessoasComIdade)
        {
            Console.WriteLine($"Nome: {pessoa.Nome}, E-mail: {pessoa.Email}");
        }
    }
    else
    {
        Console.WriteLine($"Nenhuma pessoa encontrada com {idadeParaBuscar} Anos.");
    }
}
else
{
    Console.WriteLine($"O arquivo {fileName} não existe.");
}

// Exercício 04 - Criar um programa que lê um arquivo JSON contendo informações de várias pessoas, desserializa essas informações em uma lista e exibe na tela.

using Atividade04.Modelos;
using System.Text.Json;

string fileName = "pessoas.json";

if (File.Exists(fileName))
{
    string jsonString = File.ReadAllText(fileName);

    List<GerarPessoa> pessoas = JsonSerializer.Deserialize<List<GerarPessoa>>(jsonString);

    Console.WriteLine("Informações das Pessoas:");

    foreach (GerarPessoa pessoa in pessoas)
    {
        Console.WriteLine($"Nome: {pessoa.Nome}, Idade: {pessoa.Idade}, E-mail: {pessoa.Email}");
    }
}
else
{
    Console.WriteLine($"O arquivo {fileName} não existe.");
}

// Exercício 03 - Criar um programa que permite ao usuário inserir informações de várias pessoas, armazena essas informações em uma lista, serializa a lista em formato JSON e salva em um arquivo.

using Atividade04.Modelos;
using System.Text.Json;

List<GerarPessoa> pessoas = new List<GerarPessoa>();

// Permitir ao usuário inserir informações de várias pessoas
while (true)
{
    GerarPessoa pessoa = new GerarPessoa();
    Console.Write("Digite o Nome da Pessoa (ou 'SAIR' para Encerrar o Programa): ");
    string nome = Console.ReadLine();

    if (nome.ToLower() == "SAIR")
        break;

    pessoa.Nome = nome;

    Console.Write("Digite a Idade da Pessoa: ");
    pessoa.Idade = int.Parse(Console.ReadLine());

    Console.Write("Digite o E-mail da Pessoa: ");
    pessoa.Email = Console.ReadLine();

    // Adicionar pessoa à lista
    pessoas.Add(pessoa);
}

// Serializar a lista em JSON
string jsonString = JsonSerializer.Serialize(pessoas);

// Nome do arquivo para salvar
string fileName = "pessoas.json";

// Escrever JSON no arquivo
File.WriteAllText(fileName, jsonString);

Console.WriteLine($"Os dados foram salvos em {fileName}");

using Atividade04.Modelos;
using System.Text.Json;

GerarPessoa pessoa = new GerarPessoa();
Console.Write("Digite o Nome da Pessoa: ");
pessoa.Nome = Console.ReadLine()!;
Console.Write("Digite a Idade da Pessoa: ");
pessoa.Idade = int.Parse(Console.ReadLine()!);
Console.Write("Digite o E-mail da Pessoa: ");
pessoa.Email = Console.ReadLine()!;

string jsonString = JsonSerializer.Serialize(pessoa);

string fileName = "pessoa.json";

File.WriteAllText(fileName, jsonString);

Console.WriteLine($"Os dados foram salvos em {fileName}");

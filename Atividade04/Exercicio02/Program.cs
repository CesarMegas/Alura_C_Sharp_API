// Exercício 02 - Criar um programa que lê um arquivo JSON contendo informações de uma pessoa, desserializa essas informações e exibe na tela.

string fileName = "pessoa.json";

if (File.Exists(fileName))
{
    string jsonString = File.ReadAllText(fileName);

    GerarPessoa pessoa = JsonSerializer.Deserialize<GerarPessoa>(jsonString);

    Console.WriteLine($"Nome da Pessoa: {pessoa.Nome}");
    Console.WriteLine($"Idade da Pessoa: {pessoa.Idade}");
    Console.WriteLine($"E-mail da Pessoa: {pessoa.Email}");
}
else
{
    Console.WriteLine($"O arquivo {fileName} não existe.");
}

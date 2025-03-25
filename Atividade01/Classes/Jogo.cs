namespace Atividade01.Classes;
class Jogo
{
    public string Nome { get; set; }

    public void MostrarNome()
    {
        Console.WriteLine($"O nome do Jogo é: {Nome}");
    }
}

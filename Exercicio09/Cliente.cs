using Exercicio09.Interfaces;

public class Cliente : IRelatorio
{
    public string? Nome { get; set; }

    public void GerarRelatorio()
    {
        Console.WriteLine($"Gerando relatório do Cliente: {Nome}...");
    }
}
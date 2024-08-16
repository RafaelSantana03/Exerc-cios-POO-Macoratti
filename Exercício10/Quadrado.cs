namespace Exercício10;

public class Quadrado : Area
{
    public double Lado { get; set; }
    public override void CalcularArea()
    {
        double area = Lado * Lado;
        Console.WriteLine($"Área do quadrado: {area}");
    }
}

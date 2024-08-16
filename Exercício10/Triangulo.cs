namespace Exercício10;

public class Triangulo : Area
{
    public double Altura { get; set; }
    public double Base { get; set; }
    public override void CalcularArea()
    {
        double area = (Base * Altura) / 2;
        Console.WriteLine($"Área do triangulo: {area}");
    }
}

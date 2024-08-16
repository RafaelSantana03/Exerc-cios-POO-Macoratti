namespace Exercício10;

public class Circulo : Area
{
    public double Raio { get; set; }

    //Método que calcula area do circulo
    public override void CalcularArea()
    {
        double area = Math.PI * Math.Pow(Raio, 2);
        Console.WriteLine($"Área do circulo: {area:F2}");
    }
}

INota1 p = new Exibir();
p.Classificacao();

INota2 nota2 = new Exibir();
nota2.Classificacao();
Console.ReadKey();
interface INota1
{
    void Classificacao();
}
interface INota2
{
    void Classificacao();
}
class Exibir : INota1, INota2
{
    void INota1.Classificacao()
    {
        Console.WriteLine("Classificacao INota1");
    }
    void INota2.Classificacao()
    {
        Console.WriteLine("Classificacao INota2");
    }
}


using Exercício10;

List<Area> formas = new List<Area>();

//Criando e adicionando um círculo à lista
Circulo circulo = new Circulo();
Console.Write("Digite o valor do raio: ");
circulo.Raio = double.Parse(Console.ReadLine());
formas.Add(circulo);
//circulo.CalcularArea();

//Criando e adicionando um quadrado à lista
Quadrado quadrado = new Quadrado();
Console.Write($"\nDigite o valor do lado do quadrado: ");
quadrado.Lado = double.Parse(Console.ReadLine());

formas.Add(quadrado);
//quadrado.CalcularArea();

//Criando e adicionando um triângulo à lista
Triangulo triangulo = new Triangulo();
Console.Write("\nDigite a base do triangulo: ");
triangulo.Base = double.Parse(Console.ReadLine());
Console.Write("\nDigite altura do triangulo: ");
triangulo.Altura = double.Parse(Console.ReadLine());
formas.Add(triangulo);
//triangulo.CalcularArea();

//Calculando área de cada forma
foreach (Area area in formas)
{
    area.CalcularArea();
}

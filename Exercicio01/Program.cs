

using Exercicio01;

Carro carro = new Carro(0);


Console.WriteLine("Quanto de gasolina abastecer?");
int quantidadeAbastecer = int.Parse(Console.ReadLine());

carro.Abastecer(quantidadeAbastecer);
carro.Dirigir();


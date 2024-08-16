Console.WriteLine("## Exercicio 08 ##\n");


// Criando um objeto da classe derivada usando uma referência da classe base
Animal meuAnimal = new Cachorro();

// Chama o método sobrescrito na classe derivada
meuAnimal.FazerSom(); // Saída: "O cachorro late."

// Classe base
class Animal
{
    public virtual void FazerSom()
    {
        Console.WriteLine("O animal faz um som.");
    }
}

// Classe derivada
class Cachorro : Animal
{
    public override void FazerSom()
    {
        Console.WriteLine("O cachorro late.");
    }
}

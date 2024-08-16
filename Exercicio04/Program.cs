Console.WriteLine("\n## Exercício 4 ##\n");


Pessoa[] pessoas = new Pessoa[3];

for (int i = 0; i < pessoas.Length; i++)
{
    Console.WriteLine("Informe o nome da pessoa:");
    string nome = Console.ReadLine();

    pessoas[i] = new Pessoa(nome);
}

foreach (var item in pessoas)
{
    if (item is Pessoa pessoa)
    {
        Console.WriteLine(pessoa.ToString());
    }
    
}

public class Pessoa
{
    public string? Nome { get; set; }

    public Pessoa(string nome)
    {
        Nome = nome;
    }

    public override string ToString()
    {
        return $"Nome {Nome}";
    }
}

using Exercicio03;

Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("\n## Exercício 4 ##\n");
Console.ResetColor();

//Criando uma matriz de objetos do tipo pessoa
Pessoa[] pessoas = new Pessoa[3];

//Solicitando os nomes e armazenando na matriz
for (int i = 0; i < pessoas.Length; i++)
{
    Console.WriteLine($"Digite o nome da pessoa {i + 1}");
    string nome = Console.ReadLine();  

    if(i < 2)//As duas primeiras pessoas são alunos
    {
        pessoas[i] = new Aluno(nome);
    }
    else //A Última pessoa é um professor
    {
        pessoas[i] = new Professor(nome);
    }
}

foreach (var item in pessoas)
{
    if(item is Aluno aluno)
    {
        aluno.Estudar();
    }
    else if (item is Professor professor)
    {
        professor.Explicar();        
    }
            
        
}





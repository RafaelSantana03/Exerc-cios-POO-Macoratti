using Exercicio05;

Console.WriteLine("## Exercício 5 ##");

Database db = new SQLServer();
db.Configurar();
db.Conectar();

Console.ReadKey();

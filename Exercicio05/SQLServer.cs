﻿namespace Exercicio05;

public class SQLServer : Database
{
    public override void Conectar()
    {
        Console.WriteLine("Conectando ao SQL Server...");
    }

    public override void Configurar()
    {
        Console.WriteLine("Configurando o banco de dados");
    }
}

using Exercicio09;
using Exercicio09.Interfaces;

Console.WriteLine("## Exercício 9 ##\n");

ContaCorrente conta = new ContaCorrente();
Cliente cliente = new Cliente { Nome = "João" };

// Chamando o método de relatório usando a interface IRelatorio
IRelatorio relatorioConta = conta;
IRelatorio relatorioCliente = cliente;

relatorioConta.GerarRelatorio();
relatorioCliente.GerarRelatorio();
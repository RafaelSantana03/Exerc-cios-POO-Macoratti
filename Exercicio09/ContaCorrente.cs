using Exercicio09.Interfaces;

namespace Exercicio09;

public class ContaCorrente : ContaBase, IRelatorio
{
    public override void Sacar(decimal valor)
    {
        // Implementação específica para Conta Corrente
        base.Sacar(valor);
    }

    public void GerarRelatorio()
    {
        Console.WriteLine("Gerando relatório da Conta Corrente...");
    }
}

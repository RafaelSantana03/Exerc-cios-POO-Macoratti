namespace Exercicio09.Interfaces;

public abstract class ContaBase : IConta
{
    public decimal Saldo { get; protected set; }

    public virtual void Sacar(decimal valor)
    {
        if (Saldo >= valor)
        {
            Saldo -= valor;
        }
    }

    public void Depositar(decimal valor)
    {
        Saldo += valor;
    }
}
namespace Exercicio01;

public class Carro : IVeiculo
{
    /* construtor que receba um parâmetro com a 
    quantidade inicial de gasolina do carro */
    public Carro(int gasolinaInicial)
    {
         quantidadeGasolina = gasolinaInicial;
    }
    public int quantidadeGasolina {  get; set; }

    //Implementando os métodos Dirigir() e Abastecer()
    public void Dirigir()
    {
        if (quantidadeGasolina > 0)
        {
            Console.WriteLine("Dirigindo o carro...");
        }
        else
        {
            Console.WriteLine("Sem Gasolina");
        }
    }
    public bool Abastecer(int quantidadeGasolinaAbastecer)
    {
        Console.WriteLine($"Você abasteceu {quantidadeGasolinaAbastecer}");
        quantidadeGasolina = quantidadeGasolina + quantidadeGasolinaAbastecer;
        return true;
    }

}

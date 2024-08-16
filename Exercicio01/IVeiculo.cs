namespace Exercicio01;

interface IVeiculo
{
    int quantidadeGasolina {get; set; }
    void Dirigir();
    bool Abastecer(int quantidadeGasolinaAbastecer);
    
}

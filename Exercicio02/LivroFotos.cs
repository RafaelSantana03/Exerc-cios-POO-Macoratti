namespace Exercicio02;

public class LivroFotos
{
    private int numPaginas {  get; set; }

    public int GetNumeroPaginas()
    {
        return numPaginas;      
    }
    //Construtor padrão que inicializa o número de paginas como 16
    public LivroFotos()
    {
        numPaginas = 16;
    }

    //Construtor adcional para especificar o número de paginas que queremos
    public LivroFotos(int NumeroPaginas)
    {
        numPaginas = NumeroPaginas;
    }
    
}

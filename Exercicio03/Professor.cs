namespace Exercicio03
{
    public class Professor : Pessoa
    {
        public Professor(string nome) : base(nome)
        {
        }

        public void Explicar()
        {
            Console.WriteLine($"Professor {Nome} está Explicando");
        }
    }
}

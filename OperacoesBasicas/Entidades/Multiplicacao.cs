using OperacoesBasicas.Interfaces;

namespace OperacoesBasicas.Entidades
{
    public class Multiplicacao : IOperacoes
    {
        public double Calcular(int a, int b)
        {
            return a * b;
        }
    }
}

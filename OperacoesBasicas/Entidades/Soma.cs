using OperacoesBasicas.Interfaces;

namespace OperacoesBasicas.Entidades
{
    public class Soma : IOperacoes
    {
        public double Calcular(int a, int b)
        {
            return a + b;
        }
    }
}

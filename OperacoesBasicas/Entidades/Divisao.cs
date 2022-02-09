using OperacoesBasicas.Interfaces;

namespace OperacoesBasicas.Entidades
{
    public class Divisao : IOperacoes
    {
        public double Calcular(int a, int b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Impossível divisão por zero");
            }

            return (double) a / b;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RendaFuncionario.Entidades
{
    public class Funcionario
    {
        public string Nome { get; set; }
        public string Matricula { get; set; }
        public double Salario { get; set; }
        public DateTime DataAdmissao { get; set; }
        public string CPF { get; set; }

        public Funcionario(string nome, string matricula, double salario, DateTime dataAdmissao, string cpf)
        {
            Nome = nome;
            Matricula = matricula;
            Salario = salario;
            DataAdmissao = dataAdmissao;
            CPF = cpf;
        }

        public void ReceberAumento(double aumento)
        {
            if (aumento > 0)
            {
                Salario += aumento;
            }
        }

        public double CalcularGanhoBrutoAnual()
        {
            return Salario * 12;
        }

        public double CalcularImposto()
        {
            double descontoINSS = Salario * 0.11;
            double valorExcedente = Salario - 2500;
            double descontoIR = 0;

            if (valorExcedente > 2500)
            {
                descontoIR = valorExcedente * 0.175;
            }

            return descontoINSS + descontoIR;
        }

        public double CalcularGanhoLiquidoMensal()
        {
            double imposto = CalcularImposto();

            return Salario - imposto;
        }

        public double CalcularGanhoLiquidoAnual()
        {
            double salarioLiquido = CalcularGanhoLiquidoMensal();

            return salarioLiquido * 12;
        }

        public override string ToString()
        {
            return $"Nome: {Nome} | Matricula: {Matricula} | CPF: {CPF} | Salario: {Salario} | Data de admissão: {DataAdmissao.ToString("dd/MM/yyyy")}";
        }
    }
}

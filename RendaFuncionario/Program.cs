// See https://aka.ms/new-console-template for more information
using RendaFuncionario.Entidades;

var funcionario = new Funcionario("Deniel", "GFT_2022_432", 5000f, new DateTime(2022, 2, 9), "123.456.789-10");

Console.WriteLine("Dados do funcionário: ");
Console.WriteLine(funcionario);
funcionario.ReceberAumento(300f);

Console.WriteLine("\nDados do funcionário após aumento: ");
Console.WriteLine(funcionario);

double ganhoBrutoAnual = funcionario.CalcularGanhoBrutoAnual();
double impostoMes = funcionario.CalcularImposto();
double salarioLiquidoMes = funcionario.CalcularGanhoLiquidoMensal();
double salarioLiquidoAnual = funcionario.CalcularGanhoLiquidoAnual();

Console.WriteLine($"\nGanho bruto anual: ${ganhoBrutoAnual:n2}");
Console.WriteLine($"Imposto mensal: ${impostoMes:n2}");
Console.WriteLine($"Salário liquido mensal: ${salarioLiquidoMes:n2}");
Console.WriteLine($"Salário liquido anual: ${salarioLiquidoAnual:n2}");

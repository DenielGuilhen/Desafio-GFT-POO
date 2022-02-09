using OperacoesBasicas.Entidades;

int a, b;

var soma = new Soma();
var substracao = new Subtracao();
var multiplicacao = new Multiplicacao();
var divisao = new Divisao();

a = 20;
b = 10;
Console.WriteLine("a = 20, b = 10");
Console.WriteLine($"Soma: {soma.Calcular(a, b)}");
Console.WriteLine($"Subtração: {substracao.Calcular(a, b)}");
Console.WriteLine($"Multiplicação: {multiplicacao.Calcular(a, b)}");
Console.WriteLine($"Divisão: {divisao.Calcular(a, b)}");

a = 198;
b = 99;
Console.WriteLine("\na = 198, b = 99");
Console.WriteLine($"Soma: {soma.Calcular(a, b)}");
Console.WriteLine($"Subtração: {substracao.Calcular(a, b)}");
Console.WriteLine($"Soma: {multiplicacao.Calcular(a, b)}");
Console.WriteLine($"Divisão: {divisao.Calcular(a, b)}");

a = 11549;
b = 9284;
Console.WriteLine("\na = 11549, b = 9284");
Console.WriteLine($"Soma: {soma.Calcular(a, b)}");
Console.WriteLine($"Subtração: {substracao.Calcular(a, b)}");
Console.WriteLine($"Multiplicação: {multiplicacao.Calcular(a, b)}");
Console.WriteLine($"Divisão: {divisao.Calcular(a, b)}");

a = 99999;
b = 9;
Console.WriteLine("\na = 99999, b = 9");
Console.WriteLine($"Soma: {soma.Calcular(a, b)}");
Console.WriteLine($"Subtração: {substracao.Calcular(a, b)}");
Console.WriteLine($"Multiplicação: {multiplicacao.Calcular(a, b)}");
Console.WriteLine($"Divisão: {divisao.Calcular(a, b)}");
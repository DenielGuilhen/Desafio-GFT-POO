using ContaBancaria.Entidades;

var contaCorrente = new ContaCorrente("12345-6", "Deniel", 1000f);
Console.WriteLine("Dados da conta corrente: ");
Console.WriteLine(contaCorrente);
Console.WriteLine($"Rendimentos: ${contaCorrente.Rendimento():n2}");

var contaPoupanca = new ContaPoupanca("65432-1", "Leined", 10000f);
Console.WriteLine("\nDados da conta poupança: ");
Console.WriteLine(contaPoupanca);
Console.WriteLine($"Rendimentos: ${contaPoupanca.Rendimento():n2}");
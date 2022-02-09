using System.Text;

string frase1 = "Meu codigo nao precisa de comentarios";
Console.WriteLine($"{frase1} | total: {SomaLetras(frase1)}");
string frase2 = "Eu conserto depois";
Console.WriteLine($"{frase2} | total: {SomaLetras(frase2)}");
string frase3 = "E so uma pequena mudanca";
Console.WriteLine($"{frase3} | total: {SomaLetras(frase3)}");

static int SomaLetras(string input)
{
    byte[] asciiBytes = Encoding.ASCII.GetBytes(input);
    int total = 0;

    for (int i = 0; i < asciiBytes.Length; i++)
    {
        byte item = asciiBytes[i];
        int valor;
        if (item >= 97 && item <= 122)
        {
            valor = item - 96;
            total += valor;
        }
        else if (item >= 65 && item <= 90)
        {
            valor = item - 64;
            total += valor;
        }
    }

    return total;
}
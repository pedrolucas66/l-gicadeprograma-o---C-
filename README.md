//Fazer um programa para ler as medidas da largura e comprimento de um terreno retangular com uma casa decimal, bem como o valor do metro quadrado do terreno com duas casas decimais. Em seguida, o programa deve mostrar o valor da área do terreno, bem como o valor do preço do terreno, ambos com duas casas decimais.

using System;
using System.Globalization;
namespace curso

{
    class Program
    {
        static void Main(string[] args)
        {
        double area, largura, preco, comprimento;
        largura = 10.0;
        comprimento = 30.0;
        area = (largura * comprimento);
        preco = (area * 200.0);
        Console.WriteLine(area.ToString("F2", CultureInfo.InvariantCulture));
        Console.WriteLine(preco.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}

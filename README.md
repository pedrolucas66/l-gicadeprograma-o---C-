
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

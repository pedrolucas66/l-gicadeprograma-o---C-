using System;
using System.Globalization;
namespace md
{
    class Program
    {
        static void Main(string[] args)
        {
         double R, raio;
         double pi = 3.14159;

         Console.WriteLine("Informe o valor do raio: ");
         R = double.Parse(Console.ReadLine());
         raio = (double) (4.0/3.0) * pi * (Math.Pow(R, 3.0));
         Console.WriteLine("O VOLUME é: " +raio.ToString("F3", CultureInfo.InvariantCulture));

        }
    }
}

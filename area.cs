using System;
using System.Globalization;
namespace curso

{
    class Program
  {
    static void Main(string[] args)
    {
      double area, perimetro, diagonal;

      Console.WriteLine("Digite a base:");
      double bAse = double.Parse(Console.ReadLine());

      Console.WriteLine("Digite a altura: ");
      double altura = double.Parse(Console.ReadLine());

      area = bAse * altura;
      Console.WriteLine("A area é: " +area.ToString("F4", CultureInfo.InvariantCulture));

      perimetro = (2 * bAse) + (2 * altura);
      Console.WriteLine("O perimetro é:" +perimetro.ToString("F4", CultureInfo.InvariantCulture));

      diagonal = Math.Sqrt(Math.Pow(bAse, 2.0) + Math.Pow(altura, 2.0));
      Console.WriteLine("O valor da diagonal é: " +diagonal.ToString("F4", CultureInfo.InvariantCulture));
        
    }
  }
}

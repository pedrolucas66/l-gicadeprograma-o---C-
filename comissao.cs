using System;
using System.Globalization;
namespace curso

{
    class Program
  {static void Main(string[] args)
    {
      string nome = Console.ReadLine();
      double vendas = double.Parse(Console.ReadLine());
      double salario = double.Parse(Console.ReadLine());
      double valorT;

      valorT = (double) salario + (vendas * 0.15);

      Console.WriteLine("O valor total que o funcionário " +nome+ " deverá receber é: " +valorT.ToString("F2", CultureInfo.InvariantCulture));
    }
  }
}

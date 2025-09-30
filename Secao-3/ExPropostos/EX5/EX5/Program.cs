using System.Globalization;

namespace EX5 {
  class Program {
    static void Main(string[] arg) {
      Console.WriteLine("Codigo peça 1");
      int codP1 = int.Parse(Console.ReadLine());

      Console.WriteLine("Quantidade peça 2");
      int quantP1 = int.Parse(Console.ReadLine());

      Console.WriteLine("Valor peça 1");
      double valorP1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

      Console.WriteLine("<------------------->");

      Console.WriteLine("Codigo peça 2");
      int codP2 = int.Parse(Console.ReadLine());

      Console.WriteLine("Quantidade peça 2");
      int quantP2 = int.Parse(Console.ReadLine());

      Console.WriteLine("Valor peça 2");
      double valorP2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

      double valorCompraP1 = (double)valorP1 * quantP1;
      double valorCompraP2 = (double)valorP2 * quantP2;

      double valorTotal = valorCompraP1 + valorCompraP2;

      Console.WriteLine($"VALOR A PAGAR: R${valorTotal.ToString("F2", CultureInfo.InvariantCulture)}");

    }
  }
}
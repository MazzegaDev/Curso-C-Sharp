using System.Globalization;

namespace EX5 {
  class Program {
    static void Main(string[] arg) {
      Console.WriteLine("Informe o Codigo e a quantidade de um item");

      string[] CodigoQuant = Console.ReadLine().Split(' ');
      int codigo = int.Parse(CodigoQuant[0]);
      int quant = int.Parse(CodigoQuant[1]);

      double total = 0.0;
      if(codigo == 5) {
        total = quant * (double)1.50;
      }else if(codigo == 4) {
        total = quant * (double)2.00;
      }else if(codigo == 3) {
        total = quant * (double)5.00;
      }else if(codigo == 2) {
        total = quant * (double)4.50;
      }else if(codigo == 1) {
        total = quant * (double)4.00;
      }
        Console.WriteLine($"Total: {total.ToString("F2", CultureInfo.InvariantCulture)}");
    }
  }
}
using System.Globalization;

namespace EX3 {
  class Program {
    static void Main(string[] args) {
      Console.WriteLine("Informe o numero de casos testes");

      int n = int.Parse(Console.ReadLine());
      for (int i = 0; i < n; i++) {
        Console.WriteLine($"Informe os valores do {i + 1} caso teste");
        string[] caso = Console.ReadLine().Split(' ');
        double a = double.Parse(caso[0], CultureInfo.InvariantCulture);
        double b = double.Parse(caso[1], CultureInfo.InvariantCulture);
        double c = double.Parse(caso[2], CultureInfo.InvariantCulture);

        double media = (a * 2.0 + b * 3.0 + c * 5.0 )/ 10.0;
        Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
      }
    }
  }
}
using System.Globalization;

namespace EX2 {
  class Program {
    static void Main(string[] args) {
      Console.WriteLine("Digite o valor do raio");
      double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

      double pi = 3.14159;

      double raioQuadrado = raio * raio;
      double calculo = pi * raioQuadrado;
      Console.WriteLine($"A = {calculo.ToString("F4", CultureInfo.InvariantCulture)}");
    }
  }
}
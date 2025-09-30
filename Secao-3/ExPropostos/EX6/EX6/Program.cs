using System.Globalization;

namespace EX6 {
  class Program {
    static void Main(string[] args) {
      Console.WriteLine("Sequencia Valor de A, B e C");
      string[] valores = Console.ReadLine().Split(' ');
      double A = double.Parse(valores[0], CultureInfo.InvariantCulture);
      double B = double.Parse(valores[1], CultureInfo.InvariantCulture);
      double C = double.Parse(valores[2], CultureInfo.InvariantCulture);
      double pi = 3.14159;

      //Triangulo
      double areaT = (double)(A * C) / 2;

      //Circulo
      double raioC = C * C;
      double areaC = (double)pi * raioC;

      //Trapezio
      double areaTRA = (double)(A + B) * C / 2;

      //Quadrado
      double areaQ = B * B;

      //Retangulo
      double areaRE = A * B;

      Console.WriteLine($"Triangulo: {areaT.ToString("F3", CultureInfo.InvariantCulture)}, Circulo: {areaC.ToString("F3", CultureInfo.InvariantCulture)}, Trapezio: {areaTRA.ToString("F3", CultureInfo.InvariantCulture)}, Retangulo: {areaRE.ToString("F3", CultureInfo.InvariantCulture)}");
    
    
    }
  }
}
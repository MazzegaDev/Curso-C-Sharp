using System.Globalization;

namespace ClasseTriangulo {
  class Program {
    static void Main(string[] args) {
      /*
          Em C# precisamos tipar as variaveis com a classe que vamos instanciar.
          Triangulo x, y
       */
      Triangulo x, y; //<-Variaveis do tipo triangulo
      x = new Triangulo();//Objeto X
      y = new Triangulo();//Objeto Y

      Console.WriteLine("Entre com as medidas do triangulo X:");
      x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
      x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
      x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

      Console.WriteLine("Entre com as medidas do triangulo Y:");
      y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
      y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
      y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

      double p = (x.A + x.B + x.C) / 2.0;
      double areaX = Math.Sqrt(p * (p - x.A) * (p - x.B) * (p - x.C) );

      p = (y.A + y.B + y.C) / 2.0;
      double areaY = Math.Sqrt(p * (p - y.A) * (p - y.B) * (p - y.C));

    }
  }
}
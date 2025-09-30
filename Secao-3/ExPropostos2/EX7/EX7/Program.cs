using System.Globalization;

namespace EX7 {
  class Program {
    static void Main(string[] args) {
      Console.WriteLine("Informe dois valores decimais");
      string[] valores = Console.ReadLine().Split(' ');
      float x = float.Parse(valores[0], CultureInfo.InvariantCulture);
      float y = float.Parse(valores[1], CultureInfo.InvariantCulture);

      //Origem
      //Eixo X
      //Eixo Y
      //Quadrante 1
      //Quadrante 2
      //Quadrante 3
      //Quadrante 4

      if(x == 0 && y == 0) {
        Console.WriteLine("Origem");
      }else if(y == 0 && x != 0) {
        //Eixo X
        Console.WriteLine("Eixo X");
      }else if(x == 0 && y != 0) {
        //Eixo Y
        Console.WriteLine("Eixo Y");
      }else if (x > 0 && y > 0) {
        //Quadrante 1
        Console.WriteLine("Q1");
      }else if(x < 0 && y > 0) {
        Console.WriteLine("Q2");
      }else if(x < 0 && y < 0) {
        Console.WriteLine("Q3");
      }else if(x > 0 && y < 0) {
        Console.WriteLine("Q4");
      }

    }
  }
}
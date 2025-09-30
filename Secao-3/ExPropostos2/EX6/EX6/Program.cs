using System.Globalization;
namespace EX6 {
  class Program {
    static void Main(string[] args) {
      Console.WriteLine("Digite um valor");
      double v1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

      //1 intervalo - 0,25
      if(v1 > 0.0 && v1<= 25.0) {
        Console.WriteLine("Intervalo [0, 25]");

        //2 intervalo - 25, 50
      }else if (v1 >25.0 && v1 <= 50.0) {
        Console.WriteLine("Intervalo [25, 50]");

        //3 intervalo - 50, 75
      }else if(v1 > 50.0 && v1 <= 75.0) {
        Console.WriteLine("Intervalo [50, 75]");

        //4 intervalo - 75, 100
      }else if(v1 > 75.0 && v1 <= 100.0) {
        Console.WriteLine("Intervalo [75, 100]");
      } else {
        Console.WriteLine("Fora de intervalo");
      }
    }
  }
}
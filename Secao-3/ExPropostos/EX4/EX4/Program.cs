using System.Globalization;

namespace EX4 {
  class Program {
    static void Main(string[] args) {
      Console.WriteLine("Numero do funcionario.");
      int num = int.Parse(Console.ReadLine());

      Console.WriteLine("Horas trabalhadas.");
      int horas = int.Parse(Console.ReadLine());

      Console.WriteLine("Valor que recebe por hora.");
      double valorPorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

      double salario = (double)valorPorHora * horas;

      Console.WriteLine($"NUMBER = {num}");
      Console.WriteLine($"SALARY =U$ {salario.ToString("F2", CultureInfo.InvariantCulture)}");
    }
  }
}
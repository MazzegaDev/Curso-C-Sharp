using System.Globalization;

namespace EX2 {
  class Program {
    static void Main(string[] args) {
      Funcionario func1, func2;
      func1 = new Funcionario();
      func2 = new Funcionario();

      Console.WriteLine("Nome e salario do funcionario");
      func1.nome = Console.ReadLine();
      func1.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

      Console.WriteLine("Nome e salario do funcionario");
      func2.nome = Console.ReadLine();
      func2.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

      double media = (func1.salario + func2.salario) / 2;
      Console.WriteLine($"Salario medio = {media.ToString("F2", CultureInfo.InvariantCulture)}");
    }
  }
}
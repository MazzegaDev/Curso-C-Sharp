using System.Globalization;

namespace TF2
{
    class Program
    {
        static void Main(string[] args)
        {
            Func f1 = new Func();
            Console.Write($"Nome: ");
            f1.Nome = Console.ReadLine();

            Console.WriteLine($"");

            Console.Write($"Salario bruto: ");
            f1.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine($"");

            Console.Write($"Imposto: ");
            f1.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine($"{f1}");

            Console.WriteLine($"");

            Console.Write($"Digite a porcentagem para aumentar o salario: ");
            f1.AumentarSalario(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));

            Console.WriteLine($"Dados atualizados: {f1}");

        }
    }
}
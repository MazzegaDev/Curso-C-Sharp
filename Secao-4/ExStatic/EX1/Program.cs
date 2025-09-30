using System.Globalization;

namespace EX1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Qual e a cotacao do dolar?");
            double cot = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine($"Quantos dolares voce vai comprar?");
            double compraDol = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double vtotal = ConversorDeMoeda.ValotTotalPagar(compraDol, cot);
            Console.WriteLine($"Valor a ser pago em reais = {vtotal.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
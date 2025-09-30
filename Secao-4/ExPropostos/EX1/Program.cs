using System.Globalization;

namespace EX1
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo ret = new Retangulo();
            Console.WriteLine($"Entre com a largura e altura do retangulo");
            ret.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            ret.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double retArea = ret.CalcArea();
            double retPeri = ret.CalcPerimetro();
            double retDiag = ret.CalcDiagonal();
            Console.WriteLine($"{ret}");

        }
    }
}
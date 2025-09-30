using System.Globalization;

namespace CriandoUmMetodo
{
    class Program
    {
        static void Main(string[] args)
        {
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

            double areaX = x.CalcArea();
            double areaY = y.CalcArea();

            if (areaX > areaY)
            {
                Console.WriteLine($"Maior area: X");
            }
            else
            {
                Console.WriteLine($"Maior area: Y");
            }
           
        }
    }
}
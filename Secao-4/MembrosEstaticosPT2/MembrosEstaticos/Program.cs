using System.Globalization;

namespace MembrosEstaticos
{
    class Program
    {

        

        static void Main(string[] args)
        {   
            

            /*
                O prefixo static nos permite usar operaçoes de uma classe
                sem que precisse fazer uma instancia
            */
            Console.WriteLine($"Entre o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double cir = Calculadora.CalcularCirc(raio);
            Console.WriteLine($"Circuferencia: {cir.ToString("F2", CultureInfo.InvariantCulture)}");

            double volume = Calculadora.Volume(raio);
            Console.WriteLine($"Volume: {volume.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Valor de PI: {Calculadora.PI.ToString("F2", CultureInfo.InvariantCulture)}");
        }
        //Static pq e chamada dentro da funcao entry point.
       

    }
}
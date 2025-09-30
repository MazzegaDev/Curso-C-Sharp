using System.Globalization;

namespace MembrosEstaticos
{
    class Program
    {
        static double PI = 3.14;
        static void Main(string[] args)
        {
            /*
                Classes possuem membros que sao atributos e metodos

                Membros estaticos fazem sentido independentemente de objetos. Sao chamados a partir do proprio nome da classe

                Exemplo de membro estatico:
                Matg.Sqrt -> Voce nao precisa instanciar uma classe para usar ele, usamos apartir de um nome de classe

                Classes que so possuem membros estaticos, pode ser uma classe
                estatica, e elas nao podem ser estanciadas

                Dentro de uma operacao estatica apenas pode aceitar outras operacoes estaticas:

                Variavel
                static double pi = 3.14;
                
                Funcao
                static double CalcularCirc(double raio)
                {
                    return 2.0 * PI * raio;
                }

                
            */
            Console.WriteLine($"Entre o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circuferencia = CalcularCirc(raio);
            Console.WriteLine($"Circuferencia: {circuferencia.ToString("F2", CultureInfo.InvariantCulture)}");

            double volume = Volume(raio);
            Console.WriteLine($"Volume: {volume.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Valor de PI: {PI.ToString("F2", CultureInfo.InvariantCulture)}");
        }
        //Static pq e chamada dentro da funcao entry point.
        static double CalcularCirc(double raio)
        {
            return 2.0 * PI * raio;
        }

        static double Volume(double raio)
        {
            return 4.0 / 3 * PI * Math.Pow(raio, 3.0);
        }

    }
}
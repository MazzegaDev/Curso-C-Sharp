using System.Globalization;

namespace VetoresPT1
{
    class Program
    {
        /*
            Vetores
            Para declarar um vetor basta definir seu tipo com os colchetes na frente depois o nome da variavel e por fim instaciar ela com o tipo do vetor e o numero de posicoes
            n = 3;
            double[] vetor = new double[n];
        */
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double[] vect = new double[n];

            for (int i = 0; i < n; i++)
            {
                vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            double sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum += vect[i];
            }
            double avg = sum / n;
            Console.WriteLine($"AVAREGE HEIGHT = {avg.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
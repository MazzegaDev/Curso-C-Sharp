using System.Globalization;

namespace EX3
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno n1 = new Aluno();

            Console.Write($"Nome do aluno: ");
            n1.Nome = Console.ReadLine();

            Console.Write($"Digite as tres notas do aluno: ");
            string[] val = Console.ReadLine().Split(' ');
            n1.N1 = double.Parse(val[0], CultureInfo.InvariantCulture);
            n1.N2 = double.Parse(val[1], CultureInfo.InvariantCulture);
            n1.N3 = double.Parse(val[2], CultureInfo.InvariantCulture);

            Console.WriteLine($"Nota final = {n1.CalcularNotaFinal().ToString("F2", CultureInfo.InvariantCulture)}");
            if (n1.Verificar() >= 60)
            {
               
                Console.WriteLine($"Aprovado");
            }
            else
            {
                Console.WriteLine($"Reprovado");
                Console.WriteLine($"Faltaram: {n1.Verificar().ToString("F2", CultureInfo.InvariantCulture)}");
            }

        }
    }
}